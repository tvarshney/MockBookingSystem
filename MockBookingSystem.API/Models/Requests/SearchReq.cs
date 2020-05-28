using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Models.Requests
{
    public class SearchReq
    {
        [Required]
        [RegularExpression("SKP|BCN|CPH")]
        public string Destination { get; set; }
        public string DepartureAirport { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }
    }
}
