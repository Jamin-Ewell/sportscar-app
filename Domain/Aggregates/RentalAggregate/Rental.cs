using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Aggregates.RentalAggregate;
public class Rental
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Location { get; set; } = string.Empty;
    public bool IsInsured { get; set; }
    public int Mileage { get; set; }
    public User? User { get; set; }
    public Dealer? Dealer { get; set; }
}
