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
        private readonly IManager _service;

        public BookController(IManager service)
        {
            _service = service;
        }

    }
}
