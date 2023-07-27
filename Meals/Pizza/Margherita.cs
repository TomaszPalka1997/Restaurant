using System;
namespace Restaurant.Meals.Pizza
{
    public class Margherita
    {
        public string NameOfDish { get; set; } = "Capricciosa";
        public bool IsVegan { get; set; } = false;
        public decimal Prize { get; set; } = (decimal)20.99;
        public List<string> Ingredients { get; set; }
        public int SizeInCm { get; set; } = 32;
        public string TypeOfPizza { get; set; } = "";

        public Margherita()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public void PrepareADish()
        {
            Console.WriteLine("Margherita prepared");
        }
        public void ShowIngredients()
        {
            foreach (string element in Ingredients)
            {
                Console.Write($"{element} ");
            }
        }
    }
}

