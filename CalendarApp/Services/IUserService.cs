using CalendarApp.DTO;

namespace CalendarApp.Services
{
    public interface IUserService
    {
        int Login(string username, string password);
        void Register(AddUserDTO newUser);
    }
}
