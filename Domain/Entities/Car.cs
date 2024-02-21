using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities;
public class Car
{
    public int Id { get; private set; }
    public string Make { get; private set; } 
    public string Model { get; private set; }
    public int Year { get; private set; }
    public bool IsRented { get; private set; }

    // Adjusted constructor parameters to include Make and Year, matching the class properties
    public Car(int id, string make, string model, int year, bool isRented)
    {
        Id = id;
        Make = make;
        Model = model;
        Year = year;
        IsRented = isRented;
    }

    public void BookCar()
    {
        IsRented = true; // Assuming you want to set IsRented to true to indicate the car is now rented
    }

    public void ReturnCar()
    {
        IsRented = false; // Assuming you want to set IsRented to false to indicate the car is no longer rented
    }
}
