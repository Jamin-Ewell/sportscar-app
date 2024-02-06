using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class Context : DbContext
    {

        public Context(DbContextOptions opts) : base(opts)
        {

        }

        public DbSet<Car>? Cars { get; set; }

        public DbSet<User>? User { get; set; }

        public DbSet<Dealer>? Dealer { get; set; }

        public DbSet<Rental>? Rental { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for Dealer
            modelBuilder.Entity<Dealer>().HasData(
                new Dealer(1, "Fast Cars Inc.", "High performance car dealer"),
                new Dealer(2, "Eco Friendly Motors", "Eco-friendly and electric cars"));

            // Seed data for User
            modelBuilder.Entity<User>().HasData(
                new User(1, "John Doe", "johndoe@example.com"),
                new User(2, "Jane Smith", "janesmith@example.com"));

            // Seed data for Car
            modelBuilder.Entity<Car>().HasData(
                new Car(1, "Sportster 3000", false),
                new Car(2, "EcoHatch 1", false));

            // one to many dealer can have many Cars
            modelBuilder.Entity<Dealer>()
                .HasMany(d => d.Cars)
                .WithOne(c => c.Dealer)
                .HasForeignKey(c => c.DealerId);
        }

    }
}
