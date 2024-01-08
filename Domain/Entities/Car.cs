using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities;
public class Car
{
    public int Id { get; set; }
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public bool IsRented { get; set; }
    public Address LastKnownAddress { get; set; } = new Address();

    public void BookCar()
    {
        IsRented = false;
    }


    public void ReturnCar()
    {
        IsRented = true;
    }


}
