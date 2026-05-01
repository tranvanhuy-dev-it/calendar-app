using CalendarApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly CalendarContext _context;

        public UserRepo(CalendarContext context)
        {
            _context = context;
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users
                .AsNoTracking()
                .FirstOrDefault(u => u.username == username);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users
                .AsNoTracking()
                .FirstOrDefault(u => u.email == email);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
