using Restaurant.Meals.Soup;
using Restaurant.Meals.Pizza;

Console.WriteLine("Hello in the restaurant");

List<Restaurant.Interfaces.IDish> dishes = new List<Restaurant.Interfaces.IDish>();

//TomatoSoup tomatoSoup = new TomatoSoup();
//Margherita margherita = new Margherita();

dishes.Add(new TomatoSoup());
dishes.Add(new Margherita());

foreach (Restaurant.Interfaces.IDish dish in dishes)
{
    dish.ShowIngredients();
}

Console.ReadLine();

