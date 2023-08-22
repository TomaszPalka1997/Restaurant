using System;
namespace Restaurant.Meals.Soup
{
    public class SoupOfTheDay : Dish<float>
    {
        public override string NameOfDish { get; set; } = "Tomato Soup";
        public override bool IsVegan { get; set; } = true;
        public override decimal Prize { get; set; } = (decimal)10.99;
        public override List<string> Ingredients { get; set; }
        public override float Portion { get; set; } = 150;

        public SoupOfTheDay()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }

    }
}

