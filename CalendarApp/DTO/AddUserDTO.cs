using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.DTO
{
    public class AddUserDTO
    {
        public string username { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string full_name { get; set; }
    }
}
