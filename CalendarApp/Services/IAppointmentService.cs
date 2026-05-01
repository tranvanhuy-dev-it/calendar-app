using CalendarApp.DTO;
using CalendarApp.Entities;
using System;
using System.Collections.Generic;

namespace CalendarApp.Services
{
    public interface IAppointmentService
    {
        List<AppointmentResponse> GetAppointmentsByUserId(int userId, DateTime date);
        List<Appointment> GetAppointmentsByDate(int userId, DateTime date);
        Appointment GetAppointmentById(int appointmentId);
        AddAppointmentResponse AddAppointment(Appointment appointment);
        AddAppointmentResponse UpdateAppointment(Appointment appointment);
        int ReplaceAppointment(int appointmentId, Appointment newAppointment);
        bool DeleteAppointment(int appointmentId);
        bool DeleteAppointments(IEnumerable<int> selectedAppointmentIds);
        int GetTodayAppointmentCount(int userId);
        int GetWeeklyAppointmentCount(int userId);
        int GetMonthlyAppointmentCount(int userId);
        List<DateTime> GetAppointmentDatesInMonth(int userId, int year, int month);
    }
}
