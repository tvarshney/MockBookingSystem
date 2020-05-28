using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MockBookingSystem.API.DbContexts;
using MockBookingSystem.API.Entities;

namespace MockBookingSystem.API.Services
{
    public class BookingSystemRepository : IBookingSystemRepository
    {
        private readonly BookingSystemDbContext _context;
        public BookingSystemRepository(BookingSystemDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            return await _context.Flights.ToListAsync();
        }

        public async Task<IEnumerable<Hotel>> GetHotelsAsync()
        {
            return await _context.Hotels.ToListAsync();
        }
    }
}
