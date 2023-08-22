﻿using System;
using System.Drawing;

namespace Restaurant.Meals.Appetizer
{
    public class Bruschetta : Dish<float>
    {
        public override string NameOfDish { get; set; } = "Bruschetta";
        public override bool IsVegan { get; set; } = true;
        public override decimal Prize { get; set; } = (decimal)12.99;
        public override List<string> Ingredients { get; set; }
        public bool WithBread { get; set; } = true;
        public override float Portion { get; set; } = 100;



        public Bruschetta()
        {
            Ingredients = new List<string>();
            Ingredients.Add("tomato");
            Ingredients.Add("water");
        }



    }
}

