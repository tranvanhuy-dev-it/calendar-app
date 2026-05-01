using CalendarApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Services
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepo _participantRepo;

        public ParticipantService(IParticipantRepo participantRepo)
        {
            _participantRepo = participantRepo;
        }
        public int JoinMeeting(int appointmentId, int userId)
        {
            return _participantRepo.AddParticipant(appointmentId, userId);
        }
    }
}
