using System;
using Restaurant.Meals.Soup;
using Restaurant.Meals.Appetizer;
using Restaurant.Meals.Pasta;
using Restaurant.Meals.Pizza;
using Restaurant.Interfaces;

namespace Restaurant
{
    public class UI
    {
        private delegate void Write(string message);
        private Write write = new Write(Console.WriteLine);

        private List<Interfaces.IDish> dishes = new List<Interfaces.IDish>();
        private Settlement settlement = new Settlement();
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public UI()
        {
            logger.Info("Application started");
        }

        public void menu()
        {
            while (true)
            {
                write("[0] Quit");
                write("[1] Take order");
                write("[2] Dish out");
                write("[3] Check wallet");
                write("[4] Take a complain");
                write("[5] Show ingradients");

                switch (TakeOptionInput())
                {
                    case 0:
                        return;
                    case 1:
                        TakeOrder();
                        break;
                    case 2:
                        //dish out;
                        break;
                    case 3:
                        ShowNumberOFGuestToday();
                        break;
                    case 4:
                        //take a complain
                        break;
                    case 5:
                        ShowIngredients(dishes);
                        break;
                }
                //Console.Clear();
            }
        }
        void TakeOrder()
        {
            write("-Appetizer:\n [11] Bruschetta\n [12] Cozza Al Limone");
            write("-Soup:\n [21]Soup of The Day\n [22] Tomato Soup");
            write("-Pizza: [31] Capricciosa\n [32] Margherita\n [33] Napoletana");
            write("-Pasta: [41] Bolognese\n [42] Carbonara\n [43] Spinacino");


            switch (TakeOptionInput())
            {
                case 11:
                    dishes.Add(new Bruschetta());
                    break;
                case 12:
                    dishes.Add(new CozzeAlLimone());
                    break;
                case 21:
                    dishes.Add(new SoupOfTheDay());
                    break;
                case 22:
                    dishes.Add(new TomatoSoup());
                    break;
                case 31:
                    dishes.Add(new Capricciosa());
                    break;
                case 32:
                    dishes.Add(new Margherita());
                    break;
                case 33:
                    dishes.Add(new Napoletana());
                    break;
                case 41:
                    dishes.Add(new Bolognese());
                    break;
                case 42:
                    dishes.Add(new Carbonara());
                    break;
                case 43:
                    dishes.Add(new Spinacino());
                    break;
            }
            Bill(dishes.Last());

        }

        void Bill(Restaurant.Interfaces.IDish dish)
        {
            settlement.Guests++;
            settlement.Wallet = dish.Prize;
        }
        void ShowNumberOFGuestToday()
        {
            write($"Number of guests Today: {settlement.Guests}");
            write($"Income from guests Today: {settlement.Wallet}");
        }
        void ShowIngredients(List<Restaurant.Interfaces.IDish> dish)
        {
            foreach (Restaurant.Interfaces.IDish dishh in dish)
            {
                dishh.ShowIngredients();
            }
        }

        int TakeOptionInput()
        {

            var rawDecision = Console.ReadLine();
            int decision = 99;
            try
            {

                decision = int.Parse(rawDecision);

            }
            catch (Exception e)
            {
                write("Wrong option typped\n" + e.Message);
                logger.Error(e);
            }
            return decision;

        }
    }
}

