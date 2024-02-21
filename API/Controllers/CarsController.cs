using Application.MediatR;
using Application.Services;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarsController(CarService carService, IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("available")]
    public async Task<IActionResult> GetAvailableCars()
    {
            var cars = await _mediator.Send(new GetAvailableCarsQuery());
            return Ok(cars);

    }
}
