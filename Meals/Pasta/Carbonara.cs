using System;
namespace Restaurant.Meals.Pasta
{
    public class Carbonara : Dish
    {
        public override string NameOfDish { get; set; } = "Carbonara";
        public override bool IsVegan { get; set; } = false;
        public override decimal Prize { get; set; } = (decimal)23.99;
        public override List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";

        public Carbonara()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public override void PrepareADish()
        {
            Console.WriteLine("Carbonara prepared");
        }

    }
}

