using System;
namespace Restaurant.Interfaces
{
    public interface IDish
    {
        public string NameOfDish { get; set; }
        public bool IsVegan { get; set; }
        public decimal Price { get; set; }
        public List<string> Ingredients { get; set; }
        public void PrepareADish();
        public void ShowInfoAboutDish();
    }
}

