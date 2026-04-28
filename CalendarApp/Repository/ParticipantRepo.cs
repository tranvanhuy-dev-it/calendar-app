using CalendarApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Repository
{
    public class ParticipantRepo
    {
        private CalendarContext _context;

        public ParticipantRepo()
        {
            _context = new CalendarContext();
        }

        public int AddParticipant(int appointmentId, int userId)
        {
            var appointment = _context.Appointments.Find(appointmentId);
            if (appointment == null) return -1;
            appointment.is_group_meeting = true;

            var exists = _context.Participants
                .Any(p => p.appointment_id == appointmentId && p.user_id == userId);

            if (exists)
                return -1;


            var participant = new Participant
            {
                appointment_id = appointmentId,
                user_id = userId
            };

            _context.Participants.Add(participant);
            _context.SaveChanges();
            return appointment.appointment_id;
        }
    }
}
