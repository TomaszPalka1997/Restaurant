using System;
namespace Restaurant.Interfaces
{
    public interface IPizza : IDish
    {
        public int SizeInCm { get; set; }
        public string TypeOfPizza { get; set; }
    }
}

