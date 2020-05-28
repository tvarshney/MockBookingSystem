using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Models.Responses
{
    public class Option
    {
        public string OptionCode { get; set; }
        public string HotelCode { get; set; }
        public string FlightCode { get; set; }
        public string ArrivalAirport { get; set; }
        public double Price { get; set; }
    }
}
