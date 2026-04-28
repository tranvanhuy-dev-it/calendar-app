using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.DTO
{
    public class AppointmentResponse
    {
        public int appointment_id { get; set; }
        public string title { get; set; }

        public string location { get; set; }

        public DateTime date { get; set; }

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }

        public int duration_minutes { get; set; }

        public bool is_group_meeting { get; set; }
    }
}
