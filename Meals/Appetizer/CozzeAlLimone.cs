using System;
namespace Restaurant.Meals.Appetizer
{
    public class CozzeAlLimone : Dish
    {
        public override string NameOfDish { get; set; } = "Cozze Al Limone";
        public override bool IsVegan { get; set; } = false;
        public override decimal Prize { get; set; } = (decimal)22.99;
        public override List<string> Ingredients { get; set; }
        public bool WithBread { get; set; } = false;

        public CozzeAlLimone()
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

