using System;
namespace Restaurant.Interfaces
{
    public interface IDish
    {
        public string NameOfDish { get; set; }
        public bool IsVegan { get; set; }
        public decimal Prize { get; set; }
        public List<string> ingredients { get; set; }

    }
}

