using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Entities
{
    public class Appointment
    {
        [Key]
        public int appointment_id { get; set; }

        [Required]
        public int user_id { get; set; }

        [Required, MaxLength(255)]
        public string title { get; set; }

        public string location { get; set; }

        public DateTime date { get; set; }

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }

        public bool is_group_meeting { get; set; }

        public int duration_minutes { get; set; }

        [ForeignKey("user_id")]
        public virtual User User { get; set; }

        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<Reminder> Reminders { get; set; }
    }
}
