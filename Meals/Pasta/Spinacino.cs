using System;
namespace Restaurant.Meals.Pasta
{
    public class Spinacino : Restaurant.Interfaces.IPasta
    {
        public string NameOfDish { get; set; } = "Spinacino";
        public bool IsVegan { get; set; } = false;
        public decimal Prize { get; set; } = (decimal)21.99;
        public List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";

        public Spinacino()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public void PrepareADish()
        {
            Console.WriteLine("Spinacino prepared");
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

