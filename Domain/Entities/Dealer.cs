using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities;
public class Dealer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Car>? Cars { get; set; }

    public void RentCar(User user, Car car)
    {
        if (car.IsRented)
        {
            throw new InvalidOperationException("Car is already rented.");
        }

        car.BookCar();
        user.Car = car;
    }

    public bool CheckCarReturn(Car car)
    {
        return !car.IsRented;
    }

    public void TakeActionOnUnreturnedCar(Car car)
    {
        if (car.IsRented)
        {
            // Logic to notify authorities
            NotifyAuthorities(car.LastKnownAddress);
        }
    }

    private void NotifyAuthorities(Address address)
    {
        var fromAddress = new MailAddress("dealer@sportcar.com", "Dealer");
        var toAddress = new MailAddress("authorities-email@sportscar.com", "Authorities");
        const string fromPassword = "mysecretpassword";
        const string subject = "Unreturned Rental Car Notification";
        string body = $"Unreturned car at {address.Street}, {address.City}, {address.PostalCode}, {address.Country}. Contact: {address.Phone}";

        var smtp = new SmtpClient
        {
            Host = "smtp.example.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
        };

        using (var message = new MailMessage(fromAddress, toAddress)
               {
                   Subject = subject,
                   Body = body
               })
        {
            smtp.Send(message);
        }
    }
}

