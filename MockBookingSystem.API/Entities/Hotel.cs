using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Entities
{
    public class Hotel
    {
        [Key]
        public int HotelCode { get; set; }
        public string HotelName { get; set; }
        public string DestinationCode { get; set; }
        public string City { get; set; }
    }
}
