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

        public DbSet<Car>? Cars { get; set; }

        public DbSet<User>? User { get; set; }

        public DbSet<Rental>? Rental { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Existing configurations

            // Configure Rental entity
            modelBuilder.Entity<Rental>().HasKey(r => r.Id); // Explicitly setting Id as the primary key

            // If you intend to use 'Rental' as a keyless entity, you would instead use:
            modelBuilder.Entity<Address>().HasNoKey();

            modelBuilder.Entity<Money>().HasNoKey();



            // Seed data for User
            modelBuilder.Entity<User>().HasData(
                new User(1, "John Doe", "johndoe@example.com"),
                new User(2, "Jane Smith", "janesmith@example.com"));

            // Seed data for Car
            // Seed data for Car
            modelBuilder.Entity<Car>().HasData(
                new Car(1,  "MakeOfSportster3000", "Sportster 3000", 2020, false),
                new Car(2,  "MakeOfEcoHatch1", "EcoHatch 1", 2020, false)
            );





        }

    }
}
