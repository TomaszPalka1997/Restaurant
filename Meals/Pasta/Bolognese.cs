using System;
namespace Restaurant.Meals.Pasta
{
    public class Bolognese : Dish<float>
    {
        public override string NameOfDish { get; set; } = "Bolognese";
        public override bool IsVegan { get; set; } = false;
        public override decimal Price { get; set; } = (decimal)25.99;
        public override List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";
        public override float Portion { get; set; } = 100;

        public Bolognese()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("pasta");
            Ingredients.Add("meat");
        }



    }
}

