using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Models.Responses
{
    public class CheckStatusRes
    {
        public BookingStatusEnum Status { get; set; }
    }
}
