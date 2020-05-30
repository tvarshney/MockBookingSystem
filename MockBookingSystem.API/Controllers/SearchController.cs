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
    [Route("api/search")]
    public class SearchController : ControllerBase
    {
        private readonly IManager _service;
        public SearchController(IManager service)
        {
            _service = service;
        }


    }
}
