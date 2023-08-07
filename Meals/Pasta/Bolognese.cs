using System;
namespace Restaurant.Meals.Pasta
{
    public class Bolognese : Dish
    {
        public override string NameOfDish { get; set; } = "Bolognese";
        public override bool IsVegan { get; set; } = false;
        public override decimal Prize { get; set; } = (decimal)25.99;
        public override List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";

        public Bolognese()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public override void PrepareADish()
        {
            Console.WriteLine("Bolognese prepared");
        }

    }
}

