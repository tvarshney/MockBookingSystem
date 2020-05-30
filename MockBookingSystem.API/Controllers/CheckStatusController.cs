using Microsoft.AspNetCore.Mvc;
using MockBookingSystem.API.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Controllers
{
    [ApiController]
    [Route("api/checkstatus")]
    public class CheckStatusController : ControllerBase
    {
        private readonly BookingSystemDbContext _context;
        public CheckStatusController(BookingSystemDbContext context)
        {
            _context = context;
        }
    }
}
