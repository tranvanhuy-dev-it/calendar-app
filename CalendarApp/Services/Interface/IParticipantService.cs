namespace CalendarApp.Services
{
    public interface IParticipantService
    {
        int JoinMeeting(int appointmentId, int userId);
    }
}
