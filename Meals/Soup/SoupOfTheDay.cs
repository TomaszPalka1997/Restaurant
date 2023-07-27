using System;
namespace Restaurant.Meals.Soup
{
    public class SoupOfTheDay : Restaurant.Interfaces.IDish
    {
        public string NameOfDish { get; set; } = "Tomato Soup";
        public bool IsVegan { get; set; } = true;
        public decimal Prize { get; set; } = (decimal)10.99;
        public List<string> Ingredients { get; set; }

        public SoupOfTheDay()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }
        public void PrepareADish()
        {
            Console.WriteLine("Soup of the day prepared");
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

