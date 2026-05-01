using CalendarApp.Entities;
using CalendarApp.Repository;
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
    public partial class AppointmentFormPage : Form
    {
        private int _userId;
        private DateTime _date;
        private int _appointmentId;
        private AppointmentService _appointmentService;
        private ParticipantService _participantService;
        public AppointmentFormPage(int userId, DateTime date, int appointmentId = 0)
        {
            InitializeComponent();
            _appointmentService = new AppointmentService();
            _participantService = new ParticipantService();
            _userId = userId;
            _appointmentId = appointmentId;
            _date = date;
            start.Value = date.Date.AddHours(9);
            end.Value = date.Date.AddHours(10);
            start.ValueChanged += (s, e) =>
            {
                start.Value = _date.Date.Add(start.Value.TimeOfDay);
            };

            end.ValueChanged += (s, e) =>
            {
                end.Value = _date.Date.Add(end.Value.TimeOfDay);
            };
            dateTxt.Text = "Ngày: " + date.ToString("dd/MM/yyyy");

            if (appointmentId > 0)
            {
                var appointment = _appointmentService.GetAppointmentById(appointmentId);
                start.Value = appointment.start_time;
                end.Value = appointment.end_time;
                title.Text = appointment.title;
                location.Text = appointment.location;

                addBtn.Text = "Lưu";
                label2.Text = "CẬP NHẬT LỊCH HẸN";
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DateTime startTime = start.Value;
            DateTime endTime = end.Value;
            int duration = (int)(endTime - startTime).TotalMinutes;
            string titleTxt = title.Text;
            string locationTxt = location.Text;

            try
            {
                if (string.IsNullOrEmpty(titleTxt))
                {
                    MessageBox.Show("Vui lòng nhập tiêu đề");
                } 
                else if (string.IsNullOrEmpty(locationTxt))
                {
                    MessageBox.Show("Vui lòng nhập địa điểm");
                } 
                else
                {
                    Appointment appointment = new Appointment
                    {
                        user_id = _userId,
                        title = titleTxt,
                        location = locationTxt,
                        date = _date.Date,
                        start_time = startTime,
                        end_time = endTime,
                        duration_minutes = duration
                    };

                    var response = new DTO.AddAppointmentResponse();
                    if (_appointmentId > 0)
                    {
                        appointment.appointment_id = _appointmentId;
                        response = _appointmentService.UpdateAppointment(appointment);
                    } 
                    else
                    {
                        response = _appointmentService.AddAppointment(appointment);
                    }

                    if (response.Result == AddAppointmentResult.Success)
                    {
                        MessageBox.Show(response.Message);
                        CreateReminder(response.AppointmentId.Value);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    else if (response.Result == AddAppointmentResult.Conflict)
                    {
                        var confirm = MessageBox.Show(
                            response.Message + "\nBạn muốn thay thế cuộc hẹn này không",
                            "Xác nhận",
                            MessageBoxButtons.YesNo);

                        if (confirm == DialogResult.Yes)
                        {
                            int id = _appointmentService.ReplaceAppointment(response.ConflictAppointmentId.Value, appointment);
                            MessageBox.Show("Đã thay thế cuộc hẹn");

                            CreateReminder(id);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }

                    else if (response.Result == AddAppointmentResult.Joined)
                    {
                        var confirm = MessageBox.Show(
                            response.Message,
                            "Xác nhận",
                            MessageBoxButtons.YesNo);

                        if (confirm == DialogResult.Yes)
                        {
                            int id = _participantService.JoinMeeting(response.ConflictAppointmentId.Value, _userId);
                            MessageBox.Show("Đã tham gia cuộc họp");
                            CreateReminder(id);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding appointment: " + ex.Message);
            }
        }

        private void CreateReminder(int appointmentId)
        {
            var remindConfirm = MessageBox.Show(
                                "Bạn có muốn đặt nhắc nhở cho lịch này không?",
                                "Nhắc nhở",
                                MessageBoxButtons.YesNo);
            if (remindConfirm == DialogResult.Yes)
            {
                ReminderFormPage frm = new ReminderFormPage(appointmentId, 0);
                frm.ShowDialog();
            }
        }
    }
}
