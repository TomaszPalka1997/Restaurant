using System;
namespace Restaurant.Interfaces
{
    public interface IPasta : IDish
    {
        public string TypeOfPasta { get; set; }
    }
}

