using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Models.Responses
{
    public class BookRes
    {
        public string BookCode { get; set; }
        public DateTime BookingTime { get; set; }
    }
}
