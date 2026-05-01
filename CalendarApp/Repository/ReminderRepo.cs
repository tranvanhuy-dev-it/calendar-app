using CalendarApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarApp.Repository
{
    public class ReminderRepo : IReminderRepo
    {
        private readonly CalendarContext _context;

        public ReminderRepo(CalendarContext context)
        {
            _context = context;
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

        public Reminder GetReminderById(int reminderId)
        {
            return _context.Reminders.Find(reminderId);
        }

        public bool DeleteReminder(int reminderId)
        {
            var reminder = _context.Reminders.Find(reminderId);
            if (reminder == null) return false;

            _context.Reminders.Remove(reminder);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteReminders(IEnumerable<int> reminderIds    )
        {
            if (reminderIds == null || !reminderIds.Any())
            {
                return false;
            }

            var remindersToDelete = _context.Reminders
                                               .Where(r => reminderIds.Contains(r.reminder_id))
                                               .ToList();

            if (!remindersToDelete.Any())
            {
                return false;
            }

            _context.Reminders.RemoveRange(remindersToDelete);
            return _context.SaveChanges() > 0;
        }

        public bool UpdateReminder(int reminderId, int beforeMinutes, string message)
        {
            var reminder = _context.Reminders.Find(reminderId);
            if (reminder == null) return false;
            reminder.remind_minutes_before = beforeMinutes;
            reminder.reminder_message = message;
            return _context.SaveChanges() > 0;
        }
    }
}
