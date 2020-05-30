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
        public BookRes Book(BookReq bookRequest)
        {
            throw new NotImplementedException();
        }

        public CheckStatusRes CheckStatus(CheckStatusReq checkStatusRequest)
        {
            throw new NotImplementedException();
        }

        public SearchRes Search(SearchReq searchRequest)
        {
            throw new NotImplementedException();
        }
    }
}
