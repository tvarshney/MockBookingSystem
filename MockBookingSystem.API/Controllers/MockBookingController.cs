using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Controllers
{
    [ApiController]
    [Route("api/mockbooking")]
    public class MockBookingController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetFlights()
        {
            return NotFound();
        }

        [HttpGet]
        public ActionResult GetHotels()
        {
            return NotFound();
        }
    }
}
