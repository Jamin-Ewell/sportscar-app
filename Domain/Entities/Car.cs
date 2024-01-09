using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities;
public class Car
{
    private Car() { }

    public Car(int id, string model, bool isRented)
    {
        Id = id;
        Model = model;
        IsRented = isRented;
    }

    public int Id { get; private set; }
    public string Make { get; private set; } = string.Empty;
    public string Model { get; private set; } = string.Empty;
    public int Year { get; private set; }
    public bool IsRented { get; private set; }
    public int DealerId { get; private set; }
    public Dealer? Dealer { get; private set; }
    public Address LastKnownAddress { get; private set; } = new Address();

    public void BookCar()
    {
        IsRented = false;
    }


    public void ReturnCar()
    {
        IsRented = true;
    }


}
