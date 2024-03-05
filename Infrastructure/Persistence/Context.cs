using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class Context : DbContext
    {

        public Context(DbContextOptions opts) : base(opts)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Rental> Rental { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Existing configurations

            // Configure Rental entity
            modelBuilder.Entity<Rental>().HasKey(r => r.Id);
            modelBuilder.Entity<Address>().HasNoKey();

            modelBuilder.Entity<Money>().HasNoKey();



            // Seed data for User
            modelBuilder.Entity<User>().HasData(
                new User(1, "John Doe", "johndoe@example.com"),
                new User(2, "Jane Smith", "janesmith@example.com"));


            // Seed data for Car
            modelBuilder.Entity<Car>().HasData(
                new Car(1,  "Honda", "Accord Sport", 2020, false),
                new Car(2,  "Hyundai", "Sonata", 2015, false),
            new Car(3, "BMW", "500 Series", 2022, false),
            new Car(4, "Mercedes", "Benz", 2024, false),
            new Car(5, "Fiat", "500", 2019, false)
            );





        }

    }
}
