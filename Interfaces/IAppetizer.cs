using System;
namespace Restaurant.Interfaces
{
    public interface IAppetizer : IDish
    {
        public bool WithBread { get; set; }
    }
}

