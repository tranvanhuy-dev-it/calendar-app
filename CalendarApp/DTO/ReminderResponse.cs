using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.DTO
{
    public class ReminderResponse
    {
        public string reminder_message { get; set; }

        public string location { get; set; }

        public DateTime appointment_date { get; set; }

        public string appointment_title { get; set; }

        public int remind_minutes_before { get; set; }

    }
}
