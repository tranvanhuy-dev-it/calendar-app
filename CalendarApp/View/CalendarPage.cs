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
            today.Text = "Hôm nay: " + _service.GetTodayAppointmentCount(userid).ToString();
            week.Text = "Tuần này: " + _service.GetWeeklyAppointmentCount(userid).ToString();
            month.Text = "Tháng này: " + _service.GetMonthlyAppointmentCount(userid).ToString();

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
        }

        private void loaddata()
        {
            dgv.DataSource = _service.GetAppointmentsByUserId(userid, DateTime.Now);
            dgvRmd.DataSource = _reminderService.GetReminders(userid);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddAppointmentPage addForm = new AddAppointmentPage(userid, calendar.SelectionStart);
            addForm.Show();
            this.Hide();
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
    }
}
