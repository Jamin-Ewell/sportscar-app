// TODO: It is usually considered as bad practice to leave unused imports. They are useless, and usually just polute source code files
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Aggregates.RentalAggregate;

// TODO: You have fields with private setters. It is not clear how will those fields be initallized - via constructor, methods etc.. Or, will they always contain the same value?
public class Rental
{
    // TODO: It is hard to imagine a case where you would need to change the ID. So, let's make a setter private
    public int Id { get; set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public bool IsInsured { get; private set; }
    public int Mileage { get; private set; }
    public User? User { get; private set; }
}
