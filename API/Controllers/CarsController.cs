using Application.Services;
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
        var cars = await _carService.GetAvailableCarsAsync();
        return Ok(cars);
    }
}
