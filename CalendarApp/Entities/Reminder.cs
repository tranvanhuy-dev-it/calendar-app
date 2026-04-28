using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Entities
{
    public class Reminder
    {
        [Key]
        public int reminder_id { get; set; }

        public int appointment_id { get; set; }

        public string reminder_message { get; set; }

        public int remind_minutes_before { get; set; }

        [ForeignKey("appointment_id")]
        public virtual Appointment Appointment { get; set; }
    }
}
