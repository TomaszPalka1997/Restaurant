using System;
namespace Restaurant.Meals.Pasta
{
    public class Bolognese : Restaurant.Interfaces.IPasta
    {
        public string NameOfDish { get; set; } = "Bolognese";
        public bool IsVegan { get; set; } = false;
        public decimal Prize { get; set; } = (decimal)25.99;
        public List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";

        public Bolognese()
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

