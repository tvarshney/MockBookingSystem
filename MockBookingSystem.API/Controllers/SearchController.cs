using Microsoft.AspNetCore.Mvc;
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
    [Route("api/search")]
    public class SearchController : ControllerBase
    {
        private readonly IBookingManager _service;
        public SearchController(IBookingManager service)
        {
            _service = service;
        }

        [HttpGet(Name = "Search")]
        [Route("search")]
        public async Task<IActionResult> Search([FromQuery] SearchReq search)
        {
            return Ok(await _service.SearchAsync(search));
        }

    }
}
