using CalendarApp.Entities;
using System;
using System.Collections.Generic;

namespace CalendarApp.Repository
{
    public interface IAppointmentRepo
    {
        List<Appointment> GetAppointmentsByUserId(int userId);

        List<Appointment> GetAppointmentsByDate(int userId, DateTime date);

        List<Appointment> GetAppointmentsByDateRange(int userId, DateTime startDate, DateTime endDate);

        List<Appointment> GetAppointmentsInTimeRange(DateTime startTime, DateTime endTime);

        List<Appointment> GetAppointmentsInTimeRange2(DateTime startTime, DateTime endTime, int appointmentId);

        Appointment GetAppointmentById(int appointmentId);

        bool AddAppointment(Appointment appointment);

        bool UpdateAppointment(Appointment appointment);

        void UpdateApointment(Appointment appointment);

        bool DeleteAppointment(int appointmentId);

        bool DeleteAppointments(IEnumerable<int> appointmentIds);

        int GetTodayAppointmentCount(int userId);

        int GetWeeklyAppointmentCount(int userId);

        int GetMonthlyAppointmentCount(int userId);

        List<DateTime> GetAppointmentDatesInMonth(int userId, int year, int month);

        bool IsTimeSlotAvailable(int userId, DateTime startTime, DateTime endTime, int? excludeAppointmentId = null);
    }
}
