using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Entities
{
    public class Flight
    {
        [Key]
        public int FlightCode { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
    }
}
