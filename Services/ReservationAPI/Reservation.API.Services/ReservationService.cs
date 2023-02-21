using System;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(10000),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
                BkgNumber = BkgNumber
            };
        }
    }
}

