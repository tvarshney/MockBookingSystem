using MockBookingSystem.API.Enums;
using MockBookingSystem.API.Helpers;
using MockBookingSystem.API.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Services
{
    public class SearchingHelpers
    {
        public SearchType GetSearchTypeFromSearchReq(SearchReq searchReq)
        {
            if (searchReq.DepartureAirport == null)
            {
                if (searchReq.FromDate.GetDaysDifferenceFromCurrentDate() <= 45)
                {
                    return SearchType.LastMinuteHotels;
                }
                return SearchType.HotelOnly;
            }
            else
            {
                return SearchType.HotelAndFlight;
            }
        }
    }
}
