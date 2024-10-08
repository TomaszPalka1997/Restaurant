﻿using System;
using Restaurant.Interfaces;

namespace Restaurant.Meals.Soup
{
    public class TomatoSoup : Dish<float>
    {
        public override string NameOfDish { get; set; } = "Tomato Soup";
        public override bool IsVegan { get; set; } = true;
        public override decimal Price { get; set; } = (decimal)10.99;
        public override List<string> Ingredients { get; set; }
        public override float Portion { get; set; } = 150;

        public TomatoSoup()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
        }

    }
}

