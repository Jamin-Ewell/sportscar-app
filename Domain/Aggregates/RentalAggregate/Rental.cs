using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Aggregates.RentalAggregate;
public class Rental
{
    public int Id { get; set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public bool IsInsured { get; private set; }
    public int Mileage { get; private set; }
    public User? User { get; private set; }
}
