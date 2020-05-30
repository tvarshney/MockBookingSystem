using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockBookingSystem.API.Models.Requests;
using MockBookingSystem.API.Models.Responses;

namespace MockBookingSystem.API.Services
{
    interface IManager
    {
        SearchRes Search(SearchReq searchRequest);
        BookRes Book(BookReq bookRequest);
        CheckStatusRes CheckStatus(CheckStatusReq checkStatusRequest);
    }
}
