using Restaurant.Meals.Soup;
using Restaurant.Meals.Pizza;

Console.WriteLine("Hello in the restaurant");

var dishes = new List<Restaurant.Interfaces.IDish>();

dishes.Add(new TomatoSoup());
dishes.Add(new Margherita());

foreach (Restaurant.Interfaces.IDish dish in dishes)
{
    dish.ShowIngredients();
}

Console.ReadLine();

