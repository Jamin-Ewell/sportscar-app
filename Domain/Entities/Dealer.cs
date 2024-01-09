using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities;
public class Dealer
{
    private Dealer() { }

    public Dealer(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public int Id { get;  private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public List<Car>? Cars { get; private set; }

    public void RentCar(User user, Car car)
    {
        if (car.IsRented)
        {
            throw new InvalidOperationException("Car is already rented.");
        }

        car.BookCar();
    }

    public bool CheckCarReturn(Car car)
    {
        return !car.IsRented;
    }


}

