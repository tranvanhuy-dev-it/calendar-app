using System;

namespace CalendarApp.Repository
{
    public interface IParticipantRepo
    {
        int AddParticipant(int appointmentId, int userId);
    }
}
