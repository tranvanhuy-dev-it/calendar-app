using CalendarApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CalendarApp.Repository
{
    public enum AddAppointmentResult { Success, Conflict, Joined }
    public class AppointmentRepo
    {
        private CalendarContext _context;

        public AppointmentRepo()
        {
            _context = new CalendarContext();
        }

        private IQueryable<Appointment> GetAppointmentsOfUserQuery(int userId)
        {
            return _context.Appointments
                .Where(a =>
                    a.user_id == userId
                    || (a.is_group_meeting &&
                        a.Participants.Any(p => p.user_id == userId))
                )
                .Include(a => a.Participants); 
        }

        public List<Appointment> GetAppointmentsByUserId(int userId)
        {
            return GetAppointmentsOfUserQuery(userId)
                .OrderBy(a => a.start_time)
                .ToList();
        }

        public List<Appointment> GetAppointmentsByDate(int userId, DateTime date)
        {
            DateTime start = date.Date;
            DateTime end = start.AddDays(1);

            return GetAppointmentsOfUserQuery(userId)
                .Where(a => a.start_time >= start && a.start_time < end)
                .OrderBy(a => a.start_time)
                .ToList();
        }

        public List<Appointment> GetAppointmentsByDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            return GetAppointmentsOfUserQuery(userId)
                .Where(a => a.start_time >= startDate && a.start_time < endDate)
                .OrderBy(a => a.start_time)
                .ToList();
        }

        public List<Appointment> GetAppointmentsInTimeRange(DateTime startTime, DateTime endTime)
        {
            DateTime start = startTime.Date;
            DateTime end = start.AddDays(1);

            return _context.Appointments
                .Where(a =>
                    a.start_time >= start &&
                    a.start_time < end &&
                    a.start_time < endTime &&
                    a.end_time > startTime
                )
                .OrderBy(a => a.start_time)
                .ToList();
        }

        public Appointment GetAppointmentById(int appointmentId)
        {
            return _context.Appointments.Find(appointmentId);
        }

        public bool AddAppointment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            return _context.SaveChanges() > 0;
        }

        public bool UpdateAppointment(Appointment appointment)
        {
            var existing = _context.Appointments.Find(appointment.appointment_id);
            if (existing == null) return false;

            existing.title = appointment.title;
            existing.location = appointment.location;
            existing.start_time = appointment.start_time;
            existing.end_time = appointment.end_time;
            existing.is_group_meeting = appointment.is_group_meeting;
            existing.duration_minutes = appointment.duration_minutes;

            return _context.SaveChanges() > 0;
        }

        public bool DeleteAppointment(int appointmentId)
        {
            var appointment = _context.Appointments.Find(appointmentId);
            if (appointment == null) return false;

            _context.Appointments.Remove(appointment);
            return _context.SaveChanges() > 0;
        }
        public bool DeleteAppointments(IEnumerable<int> appointmentIds)
        {
            if (appointmentIds == null || !appointmentIds.Any())
            {
                return false;
            }

            var remindersToDelete = _context.Reminders
                                            .Where(r => appointmentIds.Contains(r.appointment_id)) 
                                            .ToList();

            if (remindersToDelete.Any())
            {
                _context.Reminders.RemoveRange(remindersToDelete);
            }

            var appointmentsToDelete = _context.Appointments
                                               .Where(a => appointmentIds.Contains(a.appointment_id)) 
                                               .ToList();

            if (!appointmentsToDelete.Any())
            {

                if (!remindersToDelete.Any())
                {
                    return false;
                }
            }
            else
            {
                _context.Appointments.RemoveRange(appointmentsToDelete);
            }

            try
            {
                return _context.SaveChanges() > 0;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Lỗi DbUpdateException khi xóa cuộc hẹn: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                return false;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Lỗi chung khi xóa cuộc hẹn: {ex.Message}");
                return false;
            }
        }

        public int GetTodayAppointmentCount(int userId)
        {
            DateTime start = DateTime.Today;
            DateTime end = start.AddDays(1);

            return GetAppointmentsOfUserQuery(userId)
                .Count(a => a.start_time >= start && a.start_time < end);
        }

        public int GetWeeklyAppointmentCount(int userId)
        {
            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(7);

            return GetAppointmentsOfUserQuery(userId)
                .Count(a => a.start_time >= startOfWeek && a.start_time < endOfWeek);
        }

        public int GetMonthlyAppointmentCount(int userId)
        {
            DateTime today = DateTime.Today;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1);

            return GetAppointmentsOfUserQuery(userId)
                .Count(a => a.start_time >= startOfMonth && a.start_time < endOfMonth);
        }

        public List<DateTime> GetAppointmentDatesInMonth(int userId, int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);
            DateTime end = start.AddMonths(1);

            return GetAppointmentsOfUserQuery(userId)
                .Where(a => a.start_time >= start && a.start_time < end)
                .Select(a => DbFunctions.TruncateTime(a.start_time).Value)
                .Distinct()
                .ToList();
        }

        public bool IsTimeSlotAvailable(int userId, DateTime startTime, DateTime endTime, int? excludeAppointmentId = null)
        {
            var query = GetAppointmentsOfUserQuery(userId)
                .Where(a =>
                    a.start_time < endTime &&
                    a.end_time > startTime
                );

            if (excludeAppointmentId.HasValue)
            {
                query = query.Where(a => a.appointment_id != excludeAppointmentId.Value);
            }

            return !query.Any();
        }
    }
}
