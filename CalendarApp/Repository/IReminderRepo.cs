using CalendarApp.Entities;
using System.Collections.Generic;

namespace CalendarApp.Repository
{
    public interface IReminderRepo
    {
        bool AddReminder(Reminder reminder);

        List<Reminder> GetReminders(int userId);

        Reminder GetReminderById(int reminderId);

        bool UpdateReminder(int reminderId, int beforeMinutes, string message);

        bool DeleteReminder(int reminderId);

        bool DeleteReminders(IEnumerable<int> reminderIds);
    }
}
