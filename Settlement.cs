using System;
namespace Restaurant
{
    public class Settlement
    {
        public int Id { get; set; }
        private decimal wallet = 0;
        private int guests = 0;
        private DateTime date = DateTime.Now;

        public decimal Wallet
        {
            get { return wallet; }
            set
            {
                if (value > 0)
                {
                    wallet += value;
                }
            }
        }
        public int Guests
        {
            get { return guests; }
            set
            {
                guests++;
            }
        }
        public DateTime Date
        {
            get { return date; }

        }

        public Settlement()
        {
        }
    }
}

