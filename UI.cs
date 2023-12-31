﻿using System;
using Restaurant.Meals.Soup;
using Restaurant.Meals.Appetizer;
using Restaurant.Meals.Pasta;
using Restaurant.Meals.Pizza;
using Restaurant.RestaurantDB;
using Restaurant.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Text;

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
                write("[5] Take dalivery of ingredients");
                write("[6] Show ingredients");

                switch (TakeOptionInput())
                {
                    case 0:
                        SaveChangesBeforeExit();
                        return;
                    case 1:
                        TakeOrder();
                        break;
                    case 2:
                        //dish out;
                        break;
                    case 3:
                        Wallet();
                        break;
                    case 4:
                        //take a complain
                        break;
                    case 5:
                        ShowIngredients(dishes);
                        break;
                    default:
                        write("Wrong option typped");
                        break;
                }
                //Console.Clear();
            }
        }
        void TakeOrder()
        {
            write("-Appetizer:\n [11] Bruschetta\n [12] Cozza Al Limone");
            write("-Soup:\n [21]Soup of The Day\n [22] Tomato Soup");
            write("-Pizza:\n [31] Capricciosa\n [32] Margherita\n [33] Napoletana");
            write("-Pasta:\n [41] Bolognese\n [42] Carbonara\n [43] Spinacino");


            switch (TakeOptionInput())
            {
                case 11:
                    dishes.Add(new Bruschetta());
                    Bill(dishes.Last());
                    break;
                case 12:
                    dishes.Add(new CozzeAlLimone());
                    Bill(dishes.Last());
                    break;
                case 21:
                    dishes.Add(new SoupOfTheDay());
                    Bill(dishes.Last());
                    break;
                case 22:
                    dishes.Add(new TomatoSoup());
                    Bill(dishes.Last());
                    break;
                case 31:
                    dishes.Add(new Capricciosa());
                    Bill(dishes.Last());
                    break;
                case 32:
                    dishes.Add(new Margherita());
                    Bill(dishes.Last());
                    break;
                case 33:
                    dishes.Add(new Napoletana());
                    Bill(dishes.Last());
                    break;
                case 41:
                    dishes.Add(new Bolognese());
                    Bill(dishes.Last());
                    break;
                case 42:
                    dishes.Add(new Carbonara());
                    Bill(dishes.Last());
                    break;
                case 43:
                    dishes.Add(new Spinacino());
                    Bill(dishes.Last());
                    break;
                default:
                    write("Wrong option typped");
                    break;
            }
        }

        void Bill(Restaurant.Interfaces.IDish dish)
        {
            settlement.Guests++;
            settlement.Wallet = dish.Prize;
        }
        async void Wallet()
        {
            write($"Today");
            write($"Number of guests Today: {settlement.Guests}");
            write($"Income from guests Today: {settlement.Wallet}");
            write($"Date: {settlement.Date}");

            var s = new List<DailySettlement>();
            using (var context = new ApplicationDbContext())
            {
                write($"Todaadsafsdfy");
                s = await context.DailySettlements.ToListAsync();
                write($"Todaadsafsdfy");
                foreach (var item in s)
                {
                    write($"Number of guests : {item.NumberOfGuests}");
                    write($"Income from guests : {item.Wallet}");
                    write($"Date: {item.Date}");
                }
            }

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
                write("\n" + e.Message);
                logger.Error(e);
            }
            return decision;

        }

        async void SaveChangesBeforeExit()
        {
            var dailySettlement = new DailySettlement { Wallet = settlement.Wallet, NumberOfGuests = settlement.Guests };
            Console.WriteLine($"id= {dailySettlement.Id}");
            using (var context = new ApplicationDbContext())
            {
                //zrobic obiekt dailysattement, dodac go do bazy i zapisac





                //dodawanie
                await context.DailySettlements.AddAsync(dailySettlement);

                //usuwanie
                //context.Books.Remove(new Book { Id = 15 });

                try
                {
                    await context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"\n\n{e.InnerException}\n\n");
                }
            }
        }
    }
}

