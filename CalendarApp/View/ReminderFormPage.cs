using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CalendarApp.Services;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp.View
{
    public partial class ReminderFormPage : Form
    {
        private IReminderService _reminderService;
        private int _appointmentId;
        private int _reminderId;
        public ReminderFormPage(IReminderService reminderService)
        {
            InitializeComponent();
            _reminderService = reminderService;
        }

        public void InitData(int appointmentId, int reminderId = 0)
        {
            _appointmentId = appointmentId;
            _reminderId = reminderId;
            if (_reminderId > 0)
            {
                var reminder = _reminderService.GetReminderById(_reminderId);
                if (reminder != null)
                {
                    messageTxt.Text = reminder.reminder_message;
                    timeCbb.SelectedItem = reminder.remind_minutes_before.ToString();
                }
                addBtn.Text = "Lưu";
                label.Text = "CẬP NHẬT NHẮC NHỞ";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string message = messageTxt.Text;
            int before = int.Parse(timeCbb.SelectedItem.ToString());

            try
            {
                if (_reminderId > 0)
                {
                    _reminderService.UpdateReminder(_reminderId, before, message);
                    MessageBox.Show("Nhắc nhở đã được cập nhật thành công!");
                }
                else
                {
                    _reminderService.AddReminder(_appointmentId, before, message);
                    MessageBox.Show("Nhắc nhở đã được thêm thành công!");
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
