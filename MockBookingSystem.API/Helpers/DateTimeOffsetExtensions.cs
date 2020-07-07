using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.Helpers
{
    public static class DateTimeOffsetExtensions
    {
        public static int GetDaysDifferenceFromCurrentDate(this DateTime dateTime)
        {
            try
            {
                var currentDate = DateTime.UtcNow;
                System.TimeSpan diff = currentDate.Subtract(dateTime);
                var days = Convert.ToInt32((dateTime - currentDate).TotalDays);
                return days;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
