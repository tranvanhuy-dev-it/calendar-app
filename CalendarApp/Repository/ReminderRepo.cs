using CalendarApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarApp.Repository
{
    public class ReminderRepo
    {
        private CalendarContext _context;

        public ReminderRepo()
        {
            _context = new CalendarContext();
        }

        public bool AddReminder(Reminder reminder)
        {
            _context.Reminders.Add(reminder);
            return _context.SaveChanges() > 0;
        }

        public List<Reminder> GetReminders(int userId)
        {
            return _context.Reminders
                .Where(r =>
                    (r.Appointment.user_id == userId || r.Appointment.Participants.Any(p => p.user_id == userId))
                    && r.Appointment.date >= DateTime.Today
                )
                .OrderBy(r => r.Appointment.start_time)
                .ToList();
        }


        public bool DeleteReminder(int reminderId)
        {
            var reminder = _context.Reminders.Find(reminderId);
            if (reminder == null) return false;

            _context.Reminders.Remove(reminder);
            return _context.SaveChanges() > 0;
        }
    }
}
