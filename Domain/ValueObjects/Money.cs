using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects;
public record Money
{
    public string? Currency { get; private set; }
    public decimal Amount { get; private set; }
}
