using CalendarApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Services
{
    public class UserService
    {
        private Repository.UserRepo _userRepo;

        public UserService()
        {
            _userRepo = new Repository.UserRepo();
        }

        public int Login(string username, string password)
        {
            var user = _userRepo.GetUserByUserName(username);
            if (user == null)
            {
                throw new Exception("Không tìm thấy người dùng");
            }
            if (user.password != password)
            {
                throw new Exception("Sai mật khẩu");
            }
            return user.user_id;
        }

        public void Register(AddUserDTO newUser)
        {
            if (_userRepo.GetUserByUserName(newUser.username) != null)
            {
                throw new Exception("Username đã tồn tại");
            }
            if (_userRepo.GetUserByEmail(newUser.email) != null)
            {
                throw new Exception("Email đã tồn tại");
            }
            var user = new Entities.User
            {
                username = newUser.username,
                email = newUser.email,
                password = newUser.password,
                full_name = newUser.full_name
            };
            _userRepo.Add(user);
        }
    }
}
