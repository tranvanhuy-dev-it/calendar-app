using CalendarApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp.View
{
    public partial class CalendarPage : Form
    {
        private int userid;
        private AppointmentService _service;
        private ReminderService _reminderService;
        public CalendarPage(int id)
        {
            InitializeComponent();
            _service = new AppointmentService();
            _reminderService = new ReminderService();
            userid = id;
            SetGUI();
        }

        private void SetGUI()
        {
            UpdateSummaryLabels();

            loaddata();

            dgv.Columns["title"].HeaderText = "Tiêu đề";
            dgv.Columns["location"].HeaderText = "Địa điểm";
            dgv.Columns["start_time"].HeaderText = "Giờ bắt đầu";
            dgv.Columns["end_time"].HeaderText = "Giờ kết thúc";
            dgv.Columns["start_time"].DefaultCellStyle.Format = "HH:mm";
            dgv.Columns["end_time"].DefaultCellStyle.Format = "HH:mm";
            dgv.Columns["is_group_meeting"].HeaderText = "Cuộc họp nhóm";
            dgv.Columns["duration_minutes"].HeaderText = "Thời lượng (p)";
            dgv.Columns["date"].HeaderText = "Ngày";
            dgv.Columns["appointment_id"].Visible = false;

            dgvRmd.Columns["appointment_title"].HeaderText = "Cuộc hẹn";
            dgvRmd.Columns["location"].HeaderText = "Địa điểm";
            dgvRmd.Columns["remind_minutes_before"].HeaderText = "Nhắc trước (p)";
            dgvRmd.Columns["reminder_message"].HeaderText = "Nội dung nhắc";
            dgvRmd.Columns["appointment_date"].HeaderText = "Ngày cuộc hẹn";
            dgvRmd.Columns["appointment_date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvRmd.Columns["reminder_id"].Visible = false;
        }

        private void loaddata()
        {
            dgv.DataSource = _service.GetAppointmentsByUserId(userid, DateTime.Now);
            dgvRmd.DataSource = _reminderService.GetReminders(userid);
        }

        private void UpdateSummaryLabels()
        {
            today.Text = "Hôm nay: " + _service.GetTodayAppointmentCount(userid).ToString();
            week.Text = "Tuần này: " + _service.GetWeeklyAppointmentCount(userid).ToString();
            month.Text = "Tháng này: " + _service.GetMonthlyAppointmentCount(userid).ToString();
        }

        private List<int> GetSelectedAppointmentIds(DataGridView dataGridView)
        {
            List<int> selectedIds = new List<int>();
            string idColumnName = "appointment_id"; 

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    var idCell = row.Cells[idColumnName];
                    if (idCell != null && idCell.Value != null)
                    {
                        if (int.TryParse(idCell.Value.ToString(), out int id))
                        {
                            selectedIds.Add(id);
                        }
                    }
                }
            }
            return selectedIds;
        }
        private List<int> GetSelectedReminderIds(DataGridView dataGridView)
        {
            List<int> selectedIds = new List<int>();
            string idColumnName = "reminder_id"; 

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    var idCell = row.Cells[idColumnName];
                    if (idCell != null && idCell.Value != null)
                    {
                        if (int.TryParse(idCell.Value.ToString(), out int id))
                        {
                            selectedIds.Add(id);
                        }
                    }
                }
            }
            return selectedIds;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddAppointmentPage addForm = new AddAppointmentPage(userid, calendar.SelectionStart);
            addForm.ShowDialog();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dgv.DataSource = _service.GetAppointmentsByUserId(userid, calendar.SelectionStart);
        }

        private void CalendarPage_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                loaddata();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReminderPage page  = new AddReminderPage((int)dgv.CurrentRow.Cells["appointment_id"].Value);
            page.ShowDialog();
            loaddata();
        }

        private void delApmBtn_Click(object sender, EventArgs e)
        {
            List<int> selectedAppointmentIds = GetSelectedAppointmentIds(dgv);

            if (selectedAppointmentIds.Any())
            {
                DialogResult confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {selectedAppointmentIds.Count} cuộc hẹn đã chọn không?",
                    "Xác nhận xóa cuộc hẹn",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    bool success = _service.DeleteAppointments(selectedAppointmentIds); 

                    if (success)
                    {
                        MessageBox.Show("Các cuộc hẹn đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddata(); 
                    }
                    else
                    {
                        MessageBox.Show("Xóa cuộc hẹn thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một cuộc hẹn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DelRmdBtn_Click(object sender, EventArgs e) 
        {
            List<int> selectedReminderIds = GetSelectedReminderIds(dgvRmd);

            if (selectedReminderIds.Any())
            {
                DialogResult confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {selectedReminderIds.Count} nhắc nhở đã chọn không?",
                    "Xác nhận xóa nhắc nhở",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    bool success = _reminderService.DeleteReminders(selectedReminderIds); 

                    if (success)
                    {
                        MessageBox.Show("Các nhắc nhở đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhắc nhở thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhắc nhở để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
