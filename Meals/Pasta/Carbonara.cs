﻿using System;
namespace Restaurant.Meals.Pasta
{
    public class Carbonara : Dish<float>
    {
        public override string NameOfDish { get; set; } = "Carbonara";
        public override bool IsVegan { get; set; } = false;
        public override decimal Price { get; set; } = (decimal)23.99;
        public override List<string> Ingredients { get; set; }
        public string TypeOfPasta { get; set; } = "";
        public override float Portion { get; set; } = 100;

        public Carbonara()
        {
            Ingredients = new List<string>();
            Ingredients.Add("pasta");
            Ingredients.Add("meat");
        }



    }
}

