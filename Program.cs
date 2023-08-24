using Restaurant.Meals.Soup;
using Restaurant.Meals.Pizza;
using Restaurant;
using Restaurant.Meals;

while (true)
{
    var dishes = new List<Restaurant.Interfaces.IDish>();
    var settlement = new Settlement();

    UserInterface();
    TakeOrder(dishes);

    dishes.Add(new TomatoSoup());
    dishes.Add(new Margherita());

    ShowIngredients(dishes);
    break;
}

void UserInterface()
{
    Console.WriteLine("Hello in the restaurant");
}
void TakeOrder(List<Restaurant.Interfaces.IDish> dish)
{
    dish.Add(new TomatoSoup());
}
void ShowIngredients(List<Restaurant.Interfaces.IDish> dish)
{
    foreach (Restaurant.Interfaces.IDish dishh in dish)
    {
        dishh.ShowIngredients();
    }
}
Console.ReadLine();

