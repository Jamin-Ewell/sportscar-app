using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Car? Car { get; set; }

        public void RentCarFromDealer(Dealer dealer, Car car)
        {
            dealer.RentCar(this, car);
        }

        public void ReturnCarToDealer(Dealer dealer, Car car)
        {
            if (this.Car != car)
            {
                throw new InvalidOperationException("This is not the rented car.");
            }

            car.ReturnCar();
            this.Car = null;
        }
    }

}
