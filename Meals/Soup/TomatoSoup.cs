using System;
namespace Restaurant.Meals.Soup
{
    public class TomatoSoup : Restaurant.Interfaces.IDish
    {
        public string NameOfDish { get; set; } = "Tomato Soup";
        public bool IsVegan { get; set; } = true;
        public decimal Prize { get; set; } = (decimal)10.99;
        public List<string> Ingredients { get; set; }

        public TomatoSoup()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public void PrepareADish()
        {
            Console.WriteLine("Tomato Soup prepared");
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

