using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence;
using Infrastructure.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class CarRepository : ICarRepository
{
    private readonly Context _context;

    public CarRepository(Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Car>> GetAvailableCarsAsync()
    {
        if (_context.Cars == null) return Enumerable.Empty<Car>();
        return await _context.Cars.Where(c => !c.IsRented).ToListAsync();
    }
}

