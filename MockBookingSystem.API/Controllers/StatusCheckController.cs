using Microsoft.AspNetCore.Mvc;
using MockBookingSystem.API.DbContexts;
using MockBookingSystem.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Controllers
{
    [ApiController]
    [Route("api/checkstatus")]
    public class StatusCheckController : ControllerBase
    {
        private readonly IBookingManager _service;
        public StatusCheckController(IBookingManager service)
        {
            _service = service;
        }
    }
}
