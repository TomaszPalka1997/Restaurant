using System;
namespace Restaurant.Meals.Appetizer
{
    public class CozzeAlLimone : Dish<float>
    {
        public override string NameOfDish { get; set; } = "Cozze Al Limone";
        public override bool IsVegan { get; set; } = false;
        public override decimal Price { get; set; } = (decimal)22.99;
        public override List<string> Ingredients { get; set; }
        public bool WithBread { get; set; } = false;
        public override float Portion { get; set; } = 100;

        public CozzeAlLimone()
        {
            Ingredients = new List<string>();
            Ingredients.Add("clam");
            Ingredients.Add("lime");
        }



    }
}

