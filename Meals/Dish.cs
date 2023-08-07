using System;
namespace Restaurant.Meals
{
    public abstract class Dish : Restaurant.Interfaces.IDish
    {
        public abstract string NameOfDish { get; set; }
        public abstract bool IsVegan { get; set; }
        public abstract decimal Prize { get; set; }
        public abstract List<string> Ingredients { get; set; }

        public abstract void PrepareADish();
        public void ShowIngredients()
        {
            Console.WriteLine("\n Ingredients: \n");
            foreach (string element in Ingredients)
            {
                Console.Write($"{element} ");
            }
        }

        public Dish()
        {
        }
    }
}

