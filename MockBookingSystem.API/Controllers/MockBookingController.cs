using Microsoft.AspNetCore.Mvc;
using MockBookingSystem.API.Services;
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
        private IBookingSystemRepository _bookingSystemRepository;

        public MockBookingController(IBookingSystemRepository bookingSystemRepository)
        {
            _bookingSystemRepository = bookingSystemRepository;
        }

        [HttpGet]
        [Route("getflights")]
        public async Task<IActionResult> GetFlights()
        {
            var flightEntities = await _bookingSystemRepository.GetFlightsAsync();
            return Ok(flightEntities);
        }

        [HttpGet]
        [Route("gethotels")]
        public async Task<IActionResult> GetHotels()
        {
            var hotelEntities = await _bookingSystemRepository.GetHotelsAsync();
            return Ok(hotelEntities);
        }
    }
}
