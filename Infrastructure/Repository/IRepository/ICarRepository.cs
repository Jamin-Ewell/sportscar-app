using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Repository.IRepository;
public interface ICarRepository
{
    Task<IEnumerable<Car>> GetAvailableCarsAsync();
}

