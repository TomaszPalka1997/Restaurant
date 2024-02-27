using System;
namespace Restaurant.Meals.Pizza
{
    public class Napoletana : Dish<int>
    {
        public override string NameOfDish { get; set; } = "Capricciosa";
        public override bool IsVegan { get; set; } = false;
        public override decimal Price { get; set; } = (decimal)20.99;
        public override List<string> Ingredients { get; set; }
        public override int Portion { get; set; } = 32;

        public Napoletana()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("flour");
            Ingredients.Add("cheese");
            Ingredients.Add("meat");
        }
    }
}

