using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockBookingSystem.API.DbContexts;
using MockBookingSystem.API.Models.Requests;
using MockBookingSystem.API.Services;
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
        private readonly IBookingManager _service;

        public BookController(IBookingManager service)
        {
            _service = service;
        }

    }
}
