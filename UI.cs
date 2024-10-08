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
using static System.Runtime.InteropServices.JavaScript.JSType;
using Restaurant.Meals;

namespace Restaurant
{
    public class UI
    {
        private delegate void Write(string message);
        private Write write = new Write(Console.WriteLine);

        //private List<Interfaces.IDish> dishes = new List<Interfaces.IDish>();
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
                write("[2] Take suplly");
                write("[3] Check wallet");
                write("[4] Take a complain");
                write("[5] Show ingredients in magasine");

                switch (TakeOptionInput())
                {
                    case 0:
                        SaveChangesBeforeExit();
                        return;
                    case 1:
                        TakeOrder();
                        break;
                    case 2:
                        TakeSupply();
                        break;
                    case 3:
                        Wallet();
                        break;
                    case 4:
                        //take a complain
                        break;
                    case 5:
                        ShowMagasine();
                        break;
                    default:
                        write("Wrong option typped");
                        break;
                }

            }
        }
        void TakeOrder()
        {
            var x = true;
            var dishes = new List<Interfaces.IDish>();

            while (x)
            {
                write("-Appetizer:\n [11] Bruschetta\n [12] Cozza Al Limone");
                write("-Soup:\n [21]Soup of The Day\n [22] Tomato Soup");
                write("-Pizza:\n [31] Capricciosa\n [32] Margherita\n [33] Napoletana");
                write("-Pasta:\n [41] Bolognese\n [42] Carbonara\n [43] Spinacino");
                write("[99] Information about order");


                switch (TakeOptionInput())
                {
                    case 11:
                        dishes.Add(new Bruschetta());
                        CheckIngredients(dishes.Last());
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
                    case 99:
                        ShowInfoAboutDish(dishes);
                        break;
                    default:
                        write("Wrong option typped");
                        break;
                }
                write("Do you want to order something else?\n[1] Yes\n[0] No");
                if (TakeOptionInput() == 0)
                {
                    x = false;
                }

                foreach (var s in dishes)
                {
                    Bill(s);
                }

            }
        }

        void Bill(Restaurant.Interfaces.IDish dish)
        {
            settlement.Guests++;
            settlement.Wallet = dish.Price;
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
                s = await context.DailySettlements.ToListAsync();

                foreach (var item in s)
                {
                    write($"\nDate: {item.Date}");
                    write($"Number of guests : {item.NumberOfGuests}");
                    write($"Income from guests : {item.Wallet}");
                    write($"Id: {item.Id}");
                }
            }

        }
        void ShowInfoAboutDish(List<Restaurant.Interfaces.IDish> dish)
        {
            foreach (Restaurant.Interfaces.IDish dishh in dish)
            {
                dishh.ShowInfoAboutDish();
            }
            write($"Bill total: {dish.Sum(e => e.Price)}");
        }
        async void CheckIngredients(Restaurant.Interfaces.IDish dish)
        {
            using (var context = new ApplicationDbContext())
            {
                var ingredientsInMagazineList = await context.Ingredients.ToListAsync();
                //var ingredientsInMagazineMinusNewDish;
                try
                {
                    foreach (var x in dish.Ingredients)
                    {
                        List<Ingredient> ingredientsInMagazineMinusNewDish = ingredientsInMagazineList.Where(e => e.Name == x & e.Number > 0).ToList();

                        //context.Ingredients.Remove(ingredientsInMagazineList.First(e => e.Name == x));
                        //context.Ingredients.AddAsync(ingredientsInMagazineMinusNewDish.Foreach(e => e));

                        if (ingredientsInMagazineList.Where(e => e.Number > 90) != null)
                        {
                            Console.WriteLine($"There is NOOOO missing {x}");
                            //Console.WriteLine(ingredientsInMagazineList.Select(e => e.Number));

                        }
                        else if (ingredientsInMagazineList.Where(e => e.Name == x) != null)
                        {
                            Console.WriteLine($"There is missing {x}");
                        }
                        else
                        {

                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }
        void DishOut()
        {

        }

        async void ShowMagasine()
        {
            using (var context = new ApplicationDbContext())
            {
                var ingredientsInMagazineList = await context.Ingredients.ToListAsync();

                foreach (var x in ingredientsInMagazineList)
                {
                    Console.WriteLine($"Name: {x.Name} Number: {x.Number}\n");
                }
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
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    List<DailySettlement> dailySettlementsList = await context.DailySettlements.ToListAsync();

                    if (settlement.Guests != 0)
                    {
                        await context.DailySettlements.AddAsync(CheckAndOrganizeDuplicates(dailySettlementsList, context));
                    }

                    await context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"\n\n{e.InnerException}\n\n");
                }
            }
        }

        DailySettlement CheckAndOrganizeDuplicates(List<DailySettlement> dailySettlementsList, ApplicationDbContext context)
        {
            List<DailySettlement> dailySettlementsDuplicatesList = dailySettlementsList.Where(e => DateOnly.FromDateTime(e.Date) == DateOnly.FromDateTime(settlement.Date)).ToList();


            int guests = dailySettlementsDuplicatesList.Sum(e => e.NumberOfGuests) + settlement.Guests;
            decimal wallet = dailySettlementsDuplicatesList.Sum(e => e.Wallet) + settlement.Wallet;


            foreach (var s in dailySettlementsDuplicatesList)
            {
                context.Remove(s);
            }


            return new DailySettlement { Wallet = wallet, NumberOfGuests = guests, Date = settlement.Date };
        }
        async void TakeSupply()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    foreach (var ingrad in context.Ingredients)
                    {
                        ingrad.Number += 10;
                    }
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

