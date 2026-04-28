using CalendarApp.Entities;
using CalendarApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Repository
{
    public class UserRepo
    {
        private CalendarContext _context;

        public UserRepo()
        {
            _context = new CalendarContext();
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users.FirstOrDefault(u => u.username == username);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.email == email);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
