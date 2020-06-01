using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockBookingSystem.API.Models.Requests;
using MockBookingSystem.API.Models.Responses;

namespace MockBookingSystem.API.Services
{
    public interface IBookingManager
    {
        Task<SearchRes> SearchAsync(SearchReq searchRequest);
        Task<BookRes> BookAsync(BookReq bookRequest);
        Task<CheckStatusRes> CheckStatusAsync(CheckStatusReq checkStatusRequest);
    }
}
