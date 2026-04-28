using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Entities
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [Required, MaxLength(50)]
        public string username { get; set; }

        [Required, MaxLength(100)]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required, MaxLength(100)]
        public string full_name { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
