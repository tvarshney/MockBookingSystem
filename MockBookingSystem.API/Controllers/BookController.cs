using Microsoft.AspNetCore.Mvc;
using MockBookingSystem.API.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : ControllerBase
    {
        private readonly BookingSystemDbContext _context;
        public BookController(BookingSystemDbContext context)
        {
            _context = context;
        }
    }
}
