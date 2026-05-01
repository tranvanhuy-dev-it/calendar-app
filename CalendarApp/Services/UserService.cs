using CalendarApp.DTO;
using CalendarApp.Entities;
using CalendarApp.Repository;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CalendarApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public int Login(string username, string password)
        {
            var user = _userRepo.GetUserByUserName(username);
            if (user == null)
            {
                throw new Exception("Không tìm thấy người dùng");
            }

            string hashedInput = HashPassword(password);
            if (user.password != hashedInput)
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

            var user = new User
            {
                username = newUser.username,
                email = newUser.email,
                password = HashPassword(newUser.password), 
                full_name = newUser.full_name
            };

            _userRepo.Add(user);
        }
    }
}
