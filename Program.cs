using Restaurant.Meals.Soup;
using Restaurant.Meals.Pizza;

Console.WriteLine("Hello in the restaurant");

TomatoSoup tomatoSoup = new TomatoSoup();

Margherita margherita = new Margherita();

tomatoSoup.PrepareADish();
tomatoSoup.ShowIngredients();
margherita.ShowIngredients();



Console.ReadLine();

