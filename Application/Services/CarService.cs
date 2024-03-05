using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Repository.IRepository;

namespace Application.Services
{
    // TODO: Seems like this service is not needed anymore, since you have the MediatR handler now
    public class CarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IEnumerable<Car>> GetAvailableCarsAsync()
        {
            return await _carRepository.GetAvailableCarsAsync();
        }
    }

}
