using Microsoft.AspNetCore.Mvc;
using MockBookingSystem.API.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class SearchController : ControllerBase
    {
        private readonly BookingSystemDbContext _context;
        public SearchController(BookingSystemDbContext context)
        {
            _context = context;
        }
    }
}
