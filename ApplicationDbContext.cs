using System;
using Microsoft.EntityFrameworkCore;

namespace Restaurant
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        // Method to configure model with Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

