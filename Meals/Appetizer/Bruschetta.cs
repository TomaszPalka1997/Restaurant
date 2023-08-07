using System;
using System.Drawing;

namespace Restaurant.Meals.Appetizer
{
    public class Bruschetta : Dish
    {
        public override string NameOfDish { get; set; } = "Bruschetta";
        public override bool IsVegan { get; set; } = true;
        public override decimal Prize { get; set; } = (decimal)12.99;
        public override List<string> Ingredients { get; set; }
        public bool WithBread { get; set; } = true;



        public Bruschetta()
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

