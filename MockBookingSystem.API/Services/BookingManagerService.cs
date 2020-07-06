using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockBookingSystem.API.DbContexts;
using MockBookingSystem.API.Models.Requests;
using MockBookingSystem.API.Models.Responses;
using MockBookingSystem.API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace MockBookingSystem.API.Services
{
    public class BookingManagerService : IBookingManager
    {
        private readonly BookingSystemDbContext _context;
        private readonly SearchingHelpers _searchingHelpers;
        public BookingManagerService(BookingSystemDbContext context)
        {
            _context = context;
        }

        public Task<BookRes> BookAsync(BookReq bookRequest)
        {
            try
            {
                if(bookRequest == null)
                {
                    throw new ArgumentNullException(nameof(bookRequest));
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Task<CheckStatusRes> CheckStatusAsync(CheckStatusReq checkStatusRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<SearchRes> SearchAsync(SearchReq searchRequest)
        {
            try
            {
                if (searchRequest == null)
                {
                    throw new ArgumentNullException(nameof(searchRequest));
                }

                var type = _searchingHelpers.GetSearchTypeFromSearchReq(searchRequest);
                SearchRes searchResult = new SearchRes();

                var hotels = await _context.Hotels
                    .Where(x => x.DestinationCode == searchRequest.Destination)
                    .ToListAsync();
                var flights = await _context.Flights
                    .Where(x => x.ArrivalAirport == searchRequest.Destination && x.DepartureAirport == searchRequest.DepartureAirport)
                    .ToListAsync();
                var random = new Random();
                switch (type)
                {
                    case Enums.SearchType.HotelOnly:
                        foreach (var hotel in hotels)
                        {
                            Option item = new Option();
                            item.OptionCode = "random";
                            item.HotelCode = hotel.HotelCode.ToString();
                            item.FlightCode = "";
                            item.ArrivalAirport = searchRequest.Destination;
                            item.Price = random.NextDouble(100, 999);

                            searchResult.Options.Add(item);
                        }
                        break;
                    case Enums.SearchType.HotelAndFlight:
                        //do a HotelAndFlight search
                        //The response should be a combination of flights and hotels
                        foreach (var hotel in hotels)
                        {
                            Option item = new Option();


                            item.OptionCode = "random";
                            item.HotelCode = hotel.HotelCode.ToString();
                            item.FlightCode = "";
                            item.ArrivalAirport = searchRequest.Destination;
                            item.Price = random.NextDouble(100, 999);


                            searchResult.Options.Add(item);
                        }
                        foreach (var flight in flights)
                        {
                            Option item = new Option();
                            item.OptionCode = "random";
                            item.HotelCode = "";
                            item.FlightCode = flight.FlightCode.ToString();
                            item.ArrivalAirport = searchRequest.Destination;
                            item.Price = random.NextDouble(100, 999);


                            searchResult.Options.Add(item);
                        }
                        break;
                    case Enums.SearchType.LastMinuteHotels:
                        foreach (var hotel in hotels)
                        {
                            Option item = new Option();
                            item.OptionCode = "random";
                            item.HotelCode = hotel.HotelCode.ToString();
                            item.FlightCode = "";
                            item.ArrivalAirport = searchRequest.Destination;
                            item.Price = 58;

                            searchResult.Options.Add(item);
                        }
                        break;
                    default:
                        break;
                }

                return searchResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
