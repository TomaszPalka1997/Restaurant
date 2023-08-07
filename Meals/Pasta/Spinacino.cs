using System;
namespace Restaurant.Meals.Pasta
{
    public class Spinacino : Dish
    {
        public override string NameOfDish { get; set; } = "Spinacino";
        public override bool IsVegan { get; set; } = false;
        public override decimal Prize { get; set; } = (decimal)21.99;
        public override List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";

        public Spinacino()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

        public override void PrepareADish()
        {
            Console.WriteLine("Spinacino prepared");
        }

    }
}

