using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Services
{
    public interface IBookingSystemRepository
    {
        Task<IEnumerable<Entities.Flight>> GetFlightsAsync();
        Task<IEnumerable<Entities.Hotel>> GetHotelsAsync();
    }
}
