using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Restaurant.RestaurantDB;

namespace Restaurant
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DailySettlement> DailySettlements { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            optionsBuilder
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, Microsoft.Extensions.Logging.LogLevel.Information)
                .EnableSensitiveDataLogging()
                .UseSqlServer("Server=localhost;Database=msdb;User Id=sa;Password=Popcorn1;Encrypt=false");


        }

        // Method to configure model with Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

