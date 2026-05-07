using CalendarApp.DTO;
using CalendarApp.Entities;
using CalendarApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarApp.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepo _appointmentRepo;

        public AppointmentService(IAppointmentRepo appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public List<AppointmentResponse> GetAppointmentsByUserId(int userId, DateTime date)
        {
            try
            {
                var appointments = _appointmentRepo.GetAppointmentsByDate(userId, date);
                var response = new List<AppointmentResponse>();
                foreach (var appointment in appointments)
                {
                    response.Add(new AppointmentResponse
                    {
                        appointment_id = appointment.appointment_id,
                        title = appointment.title,
                        location = appointment.location,
                        date = appointment.date,
                        start_time = appointment.start_time,
                        end_time = appointment.end_time,
                        duration_minutes = appointment.duration_minutes,
                        is_group_meeting = appointment.is_group_meeting
                    });
                }
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi: {ex.Message}");
            }
        }

        public List<Appointment> GetAppointmentsByDate(int userId, DateTime date)
        {
            try
            {
                return _appointmentRepo.GetAppointmentsByDate(userId, date);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi: {ex.Message}");
            }
        }

        public Appointment GetAppointmentById(int appointmentId)
        {
            try
            {
                return _appointmentRepo.GetAppointmentById(appointmentId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi: {ex.Message}");
            }
        }

        public AddAppointmentResponse AddAppointment(Appointment appointment)
        {
            var existingAppointments = _appointmentRepo
                .GetAppointmentsInTimeRange(appointment.start_time, appointment.end_time)
                .Where(a => a.date.Date == appointment.date.Date)
                .ToList();

            var userConflict = existingAppointments.FirstOrDefault(a => a.user_id == appointment.user_id);

            if (userConflict != null)
            {
                return new AddAppointmentResponse
                {
                    Result = AddAppointmentResult.Conflict,
                    ConflictAppointmentId = userConflict.appointment_id,
                    Message = "Bạn đã có cuộc hẹn trong khung giờ này"
                };
            }

            var groupMeeting = existingAppointments.FirstOrDefault(a =>
                a.title.Trim().ToLower() == appointment.title.Trim().ToLower()
                && a.duration_minutes == appointment.duration_minutes
            );

            if (groupMeeting != null)
            {
                return new AddAppointmentResponse
                {
                    Result = AddAppointmentResult.Joined,
                    ConflictAppointmentId = groupMeeting.appointment_id,
                    Message = "Có cuộc họp nhóm trùng thời gian. Bạn có muốn tham gia không?"
                };
            }

            _appointmentRepo.AddAppointment(appointment);

            return new AddAppointmentResponse
            {
                Result = AddAppointmentResult.Success,
                AppointmentId = appointment.appointment_id,
                Message = "Tạo lịch thành công"
            };
        }

        public AddAppointmentResponse UpdateAppointment(Appointment appointment)
        {

            var existingAppointments = _appointmentRepo
                .GetAppointmentsInTimeRange(appointment.start_time, appointment.end_time)
                .Where(a => a.date.Date == appointment.date.Date)
                .ToList();

            var userConflict = existingAppointments.FirstOrDefault(a => a.user_id == appointment.user_id);

            if (userConflict != null)
            {
                return new AddAppointmentResponse
                {
                    Result = AddAppointmentResult.Conflict,
                    ConflictAppointmentId = userConflict.appointment_id,
                    Message = "Bạn đã có cuộc hẹn trong khung giờ này"
                };
            }

            var groupMeeting = existingAppointments.FirstOrDefault(a =>
                a.title.Trim().ToLower() == appointment.title.Trim().ToLower()
                && a.duration_minutes == appointment.duration_minutes
            );

            if (groupMeeting != null)
            {
                return new AddAppointmentResponse
                {
                    Result = AddAppointmentResult.Joined,
                    ConflictAppointmentId = groupMeeting.appointment_id,
                    Message = "Có cuộc họp nhóm trùng thời gian. Bạn có muốn tham gia không?"
                };
            }

            _appointmentRepo.UpdateAppointment(appointment);

            return new AddAppointmentResponse
            {
                Result = AddAppointmentResult.Success,
                Message = "Cập nhật lịch thành công",
                AppointmentId = appointment.appointment_id
            };
        }

        public int ReplaceAppointment(int appointmentId, Appointment newAppointment)
        {
            var existing = _appointmentRepo.GetAppointmentById(appointmentId);
            if (existing == null)
            {
                throw new Exception("Không tìm thấy cuộc hẹn");
            }

            _appointmentRepo.DeleteAppointment(appointmentId);
            _appointmentRepo.AddAppointment(newAppointment);

            return newAppointment.appointment_id;
        }

        public bool DeleteAppointment(int appointmentId)
        {
            return _appointmentRepo.DeleteAppointment(appointmentId);
        }

        public bool DeleteAppointments(IEnumerable<int> appointmentIds)
        {
            return _appointmentRepo.DeleteAppointments(appointmentIds);
        }

        public int GetTodayAppointmentCount(int userId)
        {
            return _appointmentRepo.GetTodayAppointmentCount(userId);
        }

        public int GetWeeklyAppointmentCount(int userId)
        {
            return _appointmentRepo.GetWeeklyAppointmentCount(userId);
        }

        public int GetMonthlyAppointmentCount(int userId)
        {
            return _appointmentRepo.GetMonthlyAppointmentCount(userId);
        }

        public List<DateTime> GetAppointmentDatesInMonth(int userId, int year, int month)
        {
            return _appointmentRepo.GetAppointmentDatesInMonth(userId, year, month);
        }
    }
}