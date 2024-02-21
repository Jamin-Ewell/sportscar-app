using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities;
public class Rental
{
    public int Id { get; set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public int Mileage { get; private set; }
    public bool IsInsured { get; private set; }
    public Car? RentedCar { get; private set; }
    public bool IsAvailable { get; private set; }

    public void StartRental()
    {
        // Logic to start rental
        StartDate = DateTime.Now;
        RentedCar?.BookCar();

    }

    public void CompleteRental()
    {
        // Logic to complete rental
        EndDate = DateTime.Now;
        RentedCar?.ReturnCar();
    }
}
