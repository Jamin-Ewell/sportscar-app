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

    public async Task<Car?> FindByIdAsync(int id)
    {
        if (_context.Cars == null) throw new InvalidOperationException("Could not find id.");
        var car = await _context.Cars.FindAsync(id);
        return car; 
    }



    public async Task UpdateAsync(Car car)
    {
        if (_context.Cars == null) throw new InvalidOperationException("Database set 'Cars' is null.");
        _context.Cars.Update(car);
        await _context.SaveChangesAsync();
    }
}

