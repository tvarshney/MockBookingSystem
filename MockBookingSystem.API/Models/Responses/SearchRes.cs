using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Models.Responses
{
    public class SearchRes
    {
        public List<Option> Options { get; set; } = new List<Option>();
    }
}
