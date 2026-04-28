using CalendarApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Services
{
    public class ParticipantService
    {
        private ParticipantRepo _participantRepo;

        public ParticipantService()
        {
            _participantRepo = new ParticipantRepo();
        }
        public int JoinMeeting(int appointmentId, int userId)
        {
            return _participantRepo.AddParticipant(appointmentId, userId);
        }
    }
}
