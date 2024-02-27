using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.RestaurantDB
{
    public class DailySettlement
    {
        public int Id { get; set; }
        public decimal Wallet { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime Date { get; set; }

        public DailySettlement()
        {
        }
    }
}

