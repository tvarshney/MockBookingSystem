using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Models.Requests
{
    public class BookReq
    {
        [Required]
        public string OptionCode { get; set; }
        [Required]
        public SearchReq SearchReq { get; set; }
    }
}
