using System;
namespace Restaurant.Meals.Appetizer
{
    public class CozzeAlLimone : Restaurant.Interfaces.IAppetizer
    {
        public string NameOfDish { get; set; } = "Cozze Al Limone";
        public bool IsVegan { get; set; } = false;
        public decimal Prize { get; set; } = (decimal)22.99;
        public List<string> Ingredients { get; set; }
        public bool WithBread { get; set; } = false;

        public CozzeAlLimone()
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

