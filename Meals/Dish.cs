using System;
namespace Restaurant.Meals
{
    public abstract class Dish<T> : Restaurant.Interfaces.IDish
    {
        public abstract string NameOfDish { get; set; }
        public abstract bool IsVegan { get; set; }
        public abstract decimal Price { get; set; }
        public abstract List<string> Ingredients { get; set; }
        public abstract T Portion { get; set; }



        public void PrepareADish()
        {
            Console.WriteLine($"{NameOfDish} Prepared");
        }
        public void ShowInfoAboutDish()
        {
            Console.Write($"\n Ingredients of {NameOfDish}: ");
            foreach (string element in Ingredients)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Is {NameOfDish} Vegan?: {IsVegan}");
            Console.WriteLine($"Price: {Price}");
        }


        public Dish()
        {
            PrepareADish();
        }
    }
}

