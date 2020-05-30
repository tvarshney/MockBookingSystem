using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockBookingSystem.API.DbContexts;
using MockBookingSystem.API.Models.Requests;
using MockBookingSystem.API.Models.Responses;

namespace MockBookingSystem.API.Services
{
    public class ManagerService : IManager
    {
        private readonly BookingSystemDbContext _context;
        public ManagerService(BookingSystemDbContext context)
        {
            _context = context;
        }

        public Task<BookRes> BookAsync(BookReq bookRequest)
        {
            throw new NotImplementedException();
        }

        public Task<CheckStatusRes> CheckStatusAsync(CheckStatusReq checkStatusRequest)
        {
            throw new NotImplementedException();
        }

        public Task<SearchRes> SearchAsync(SearchReq searchRequest)
        {
            if(searchRequest == null)
            {
                throw new ArgumentNullException(nameof(searchRequest));
            }
            throw new NotImplementedException();
        }
    }
}
