using CalendarApp.DTO;
using CalendarApp.Entities;
using System.Collections.Generic;

namespace CalendarApp.Services
{
    public interface IReminderService
    {
        bool AddReminder(int appointmentId, int minutesBefore, string message);
        List<ReminderResponse> GetReminders(int userid);
        Reminder GetReminderById(int reminderId);
        bool DeleteReminder(int reminderId);
        bool DeleteReminders(IEnumerable<int> reminderIds);
        bool UpdateReminder(int reminderId, int minutesBefore, string message);
    }
}
