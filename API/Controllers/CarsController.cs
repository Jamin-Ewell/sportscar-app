using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
    private readonly CarService _carService;

    public CarsController(CarService carService)
    {
        _carService = carService;
    }

    [HttpGet("available")]
    public async Task<IActionResult> GetAvailableCars()
    {
        try
        {
            var cars = await _carService.GetAvailableCarsAsync();

            if (cars == null)
            {
                return Ok(new List<Car>());
            }

            return Ok(cars);
        }
        catch (Exception )
        {
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}
