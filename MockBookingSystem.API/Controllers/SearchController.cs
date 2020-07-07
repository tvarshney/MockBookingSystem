using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
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
        private readonly IMemoryCache _cache;
        public SearchController(IBookingManager service)
        {
            _service = service;
        }

        [HttpGet(Name = "Search")]
        public async Task<IActionResult> Search([FromQuery] SearchReq search)
        {
            return Ok(await _service.SearchAsync(search));
        }

    }
}
