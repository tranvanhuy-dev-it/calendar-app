using CalendarApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.DTO
{
    public class AddAppointmentResponse
    {
        public AddAppointmentResult Result { get; set; }
        public int? ConflictAppointmentId { get; set; }
        public string Message { get; set; }
        public int? AppointmentId { get; set; }
    }

}
