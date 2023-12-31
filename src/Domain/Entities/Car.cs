﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportscar_app.Domain.Entities;
public class Car
{
    public int? Id { get; set; }

    public string? Make { get; set; }
    public string? Model { get; set; }

    public int Year { get; set; }
    public bool IsRented { get; set; }
    public DateTime? Rented { get; set; }
    public DateTime? Returned { get; set; }


}
