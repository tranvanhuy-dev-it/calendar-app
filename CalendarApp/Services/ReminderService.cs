using CalendarApp.DTO;
using CalendarApp.Entities;
using CalendarApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarApp.Services
{
    public class ReminderService
    {
        private ReminderRepo _reminderRepo;
        private AppointmentRepo _appointmentRepo;

        public ReminderService()
        {
            _reminderRepo = new ReminderRepo();
            _appointmentRepo = new AppointmentRepo();
        }

        // 👉 Thêm lời nhắc
        public bool AddReminder(int appointmentId, int minutesBefore, string message)
        {
            var appointment = _appointmentRepo.GetAppointmentById(appointmentId);
            if (appointment == null)
                throw new Exception("Không tìm thấy cuộc hẹn");

            if (minutesBefore < 0)
                throw new Exception("Thời gian nhắc không hợp lệ");

            var reminder = new Reminder
            {
                appointment_id = appointmentId,
                remind_minutes_before = minutesBefore,
                reminder_message = message
            };

            return _reminderRepo.AddReminder(reminder);
        }

        public List<ReminderResponse> GetReminders(int userid)
        {
            var reminders = _reminderRepo.GetReminders(userid);

            var result = reminders.Select(r => new ReminderResponse
            {
                reminder_message = r.reminder_message,
                remind_minutes_before = r.remind_minutes_before,
                appointment_title = r.Appointment.title,
                appointment_date = r.Appointment.date,
                location = r.Appointment.location
            }).ToList();

            return result;
        }


        // 👉 Xóa reminder
        public bool DeleteReminder(int reminderId)
        {
            return _reminderRepo.DeleteReminder(reminderId);
        }
    }
}
