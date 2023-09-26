using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.RestaurantDB
{
    public class DailySettlement
    {
        //[Key]
        public int Id { get; set; }
        public decimal Wallet { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime Date = DateTime.Now;

        public DailySettlement()
        {
        }
    }
}

