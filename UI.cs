using System;
using Restaurant.Meals.Soup;
using Restaurant.Meals.Appetizer;
using Restaurant.Meals.Pasta;
using Restaurant.Meals.Pizza;

namespace Restaurant
{
    public class UI
    {
        private delegate void Write(string message);
        private Write write = new Write(Console.WriteLine);

        private List<Interfaces.IDish> dishes = new List<Interfaces.IDish>();
        private Settlement settlement = new Settlement();

        public UI()
        {
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
                var rawDecision = Console.ReadLine();
                int? decision = null;
                try
                {
                    if (rawDecision != null)
                    {
                        decision = int.Parse(rawDecision);
                    }
                }
                catch
                {

                }

                switch (decision)
                {
                    case 0:
                        return;
                    case 1:
                        TakeOrder(dishes);
                        break;
                    case 2:
                        //dish out;
                        break;
                    case 3:
                        // check wallet
                        break;
                    case 4:
                        //take a complain
                        break;
                    case 5:
                        ShowIngredients(dishes);
                        break;
                    default:
                        write("Wrong option typed");
                        break;
                }
            }
        }
        void TakeOrder(List<Restaurant.Interfaces.IDish> dish)
        {
            write("-Appetizer:\n [11] Bruschetta\n [12] Cozza Al Limone");
            write("-Soup:\n [21]Soup of The Day\n [22] Tomato Soup");
            write("-Pizza: [31] Capricciosa\n [32] Margherita\n [33] Napoletana");
            write("-Pasta: [41] Bolognese\n [42] Carbonara\n [43] Spinacino");

            var rawDecision = Console.ReadLine();
            int? decision = null;
            try
            {
                if (rawDecision != null)
                {
                    decision = int.Parse(rawDecision);
                }
            }
            catch
            {

            }

            switch (decision)
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
                default:
                    write("Wrong option typed");
                    break;
            }
        }

        void Bill(List<Restaurant.Interfaces.IDish> dish)
        {

        }
        void ShowNumberOFGuestToday()
        {

        }
        void ShowIngredients(List<Restaurant.Interfaces.IDish> dish)
        {
            foreach (Restaurant.Interfaces.IDish dishh in dish)
            {
                dishh.ShowIngredients();
            }
        }
    }
}

