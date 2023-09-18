using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Restaurant.RestaurantDB;

namespace Restaurant
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DailySettlement> dailySettlements { get; set; }
        public DbSet<Ingredient> ingredient { get; set; }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var builderIngredient = new ConfigurationBuilder()
                .AddJsonFile("StoreRoom.json", true, true);

            var builderSettlement = new ConfigurationBuilder()
                .AddJsonFile("StoreRoom.json", true, true);

            var configIngredient = builderIngredient.Build();
            var configSettlement = builderSettlement.Build();


            optionsBuilder
                .UseSqlServer(configIngredient["ConnectrionStringIngredient"])
                .UseSqlServer(configSettlement["ConnectrionStringSettlement"]);

        }

        // Method to configure model with Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

