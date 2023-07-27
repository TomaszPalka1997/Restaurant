using System;
namespace Restaurant.Meals.Pasta
{
    public class Carbonara : Restaurant.Interfaces.IPasta
    {
        public string NameOfDish { get; set; } = "Carbonara";
        public bool IsVegan { get; set; } = false;
        public decimal Prize { get; set; } = (decimal)23.99;
        public List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";

        public Carbonara()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public void PrepareADish()
        {
            Console.WriteLine("Carbonara prepared");
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

