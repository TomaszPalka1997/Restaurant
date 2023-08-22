using System;
namespace Restaurant.Meals.Pasta
{
    public class Spinacino : Dish<float>
    {
        public override string NameOfDish { get; set; } = "Spinacino";
        public override bool IsVegan { get; set; } = false;
        public override decimal Prize { get; set; } = (decimal)21.99;
        public override List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";
        public override float Portion { get; set; } = 100;

        public Spinacino()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }



    }
}

