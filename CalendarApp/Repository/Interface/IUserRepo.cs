using CalendarApp.Entities;

namespace CalendarApp.Repository
{
    public interface IUserRepo
    {
        User GetUserByUserName(string username);

        User GetUserByEmail(string email);

        void Add(User user);
    }
}
