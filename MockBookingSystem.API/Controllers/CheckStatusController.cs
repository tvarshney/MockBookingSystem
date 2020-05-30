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
    public class CheckStatusController : ControllerBase
    {
        private readonly ManagerService _service;
        public CheckStatusController(ManagerService service)
        {
            _service = service;
        }
    }
}
