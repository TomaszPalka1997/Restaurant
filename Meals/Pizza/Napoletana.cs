using System;
namespace Restaurant.Meals.Pizza
{
    public class Napoletana : Dish
    {
        public override string NameOfDish { get; set; } = "Capricciosa";
        public override bool IsVegan { get; set; } = false;
        public override decimal Prize { get; set; } = (decimal)20.99;
        public override List<string> Ingredients { get; set; }
        public int SizeInCm { get; set; } = 32;
        public string TypeOfPizza { get; set; } = "";

        public Napoletana()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public override void PrepareADish()
        {
            Console.WriteLine("Napoletana prepared");
        }

    }
}

