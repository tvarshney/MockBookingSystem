using Microsoft.EntityFrameworkCore;
using MockBookingSystem.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockBookingSystem.API.DbContexts
{
    public class BookingSystemDbContext : DbContext
    {
        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Hotels 
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    HotelCode = 1,
                    HotelName = "Hotel Old Bazzar",
                    DestinationCode = "SKP",
                    City = "Skopje"
                },
                new Hotel()
                {
                    HotelCode = 2,
                    HotelName = "Skopje City Hotel",
                    DestinationCode = "SKP",
                    City = "Skopje"
                },
                new Hotel()
                {
                    HotelCode = 3,
                    HotelName = "Skopje Square Hotel",
                    DestinationCode = "SKP",
                    City = "Skopje"
                },
                new Hotel()
                {
                    HotelCode = 4,
                    HotelName = "Hotel La Niña",
                    DestinationCode = "BCN",
                    City = "Barcelona"
                },
                  new Hotel()
                  {
                      HotelCode = 5,
                      HotelName = "Niu Barcelona Hotel",
                      DestinationCode = "BCN",
                      City = "Barcelona"
                  },
                new Hotel()
                {
                    HotelCode = 6,
                    HotelName = "Golden Donaire Beach",
                    DestinationCode = "BCN",
                    City = "Barcelona"
                },
                new Hotel()
                {
                    HotelCode = 7,
                    HotelName = "Hotel Novotel Dubai Al Barsha",
                    DestinationCode = "DXB",
                    City = "Dubai"
                },
                new Hotel()
                {
                    HotelCode = 8,
                    HotelName = "Ghaya Grand Hotel",
                    DestinationCode = "DXB",
                    City = "Dubai"
                },
                new Hotel()
                {
                    HotelCode = 9,
                    HotelName = "Emirates Grand Hotel",
                    DestinationCode = "DXB",
                    City = "Dubai"
                });
            #endregion

            #region Flights
            modelBuilder.Entity<Flight>().HasData(
                new Flight()
                {
                    FlightCode = 1,
                    FlightNumber = "SK1234",
                    DepartureAirport = "CPH",
                    ArrivalAirport = "SKP"
                },
                new Flight()
                {
                    FlightCode = 2,
                    FlightNumber = "SK4321",
                    DepartureAirport = "OSL",
                    ArrivalAirport = "SKP"
                },
                new Flight()
                {
                    FlightCode = 3,
                    FlightNumber = "SK3412",
                    DepartureAirport = "STO",
                    ArrivalAirport = "SKP"
                },
                new Flight()
                {
                    FlightCode = 4,
                    FlightNumber = "BN1234",
                    DepartureAirport = "CPH",
                    ArrivalAirport = "BCN"
                },
                new Flight()
                {
                    FlightCode = 5,
                    FlightNumber = "BN4321",
                    DepartureAirport = "OSL",
                    ArrivalAirport = "BCN"
                },
                new Flight()
                {
                    FlightCode = 6,
                    FlightNumber = "BN3412",
                    DepartureAirport = "STO",
                    ArrivalAirport = "BCN"
                },
                new Flight()
                {
                    FlightCode = 7,
                    FlightNumber = "DB1234",
                    DepartureAirport = "CPH",
                    ArrivalAirport = "DXB"
                },
                new Flight()
                {
                    FlightCode = 8,
                    FlightNumber = "DB3412",
                    DepartureAirport = "OSL",
                    ArrivalAirport = "DXB"

                },
                new Flight()
                {
                    FlightCode = 9,
                    FlightNumber = "DB4321",
                    DepartureAirport = "STO",
                    ArrivalAirport = "DXB"
                });
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
