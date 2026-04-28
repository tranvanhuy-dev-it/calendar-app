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
    public partial class AddReminderPage : Form
    {
        private ReminderService _reminderService;
        private int _appointmentId;
        public AddReminderPage(int appointmentId)
        {
            InitializeComponent();
            _reminderService = new ReminderService();
            _appointmentId = appointmentId;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string message = messageTxt.Text;
            int before = int.Parse(timeCbb.SelectedItem.ToString());

            try
            {
                _reminderService.AddReminder(_appointmentId, before, message);
                MessageBox.Show("Nhắc nhở đã được thêm thành công!");

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
