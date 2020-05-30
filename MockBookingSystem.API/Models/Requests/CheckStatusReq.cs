using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Models.Requests
{
    public class CheckStatusReq
    {
        [Required]
        public string BookingCode { get; set; }
    }
}
