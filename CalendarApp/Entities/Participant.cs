using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Entities
{
    public class Participant
    {
        [Key]
        public int participant_id { get; set; }

        public int appointment_id { get; set; }
        public int user_id { get; set; }

        [ForeignKey("appointment_id")]
        public virtual Appointment Appointment { get; set; }

        [ForeignKey("user_id")]
        public virtual User User { get; set; }
    }
}
