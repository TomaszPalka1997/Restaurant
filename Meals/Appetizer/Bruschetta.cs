using System;
namespace Restaurant.Meals.Appetizer
{
    public class Bruschetta : Restaurant.Interfaces.IAppetizer
    {
        public string NameOfDish { get; set; } = "Bruschetta";
        public bool IsVegan { get; set; } = true;
        public decimal Prize { get; set; } = (decimal)12.99;
        public List<string> Ingredients { get; set; }
        public bool WithBread { get; set; } = true;

        public Bruschetta()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public void PrepareADish()
        {
            Console.WriteLine("Bolognese prepared");
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

