﻿using System;
namespace Restaurant
{
    public class Settlement
    {
        private decimal wallet = 0;
        private int guests;

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
        public Settlement()
        {
        }
    }
}
