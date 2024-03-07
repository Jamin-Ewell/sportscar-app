using Application.DTOs;
using Application.MediatR;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarsController( IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("available")]
    public async Task<IActionResult> GetAvailableCars()
    {
            var cars = await _mediator.Send(new GetAvailableCarsQuery());
            return Ok(cars);

    }

    [HttpPost("update/{carId}")]
    public async Task<IActionResult> UpdateCarStatus(int carId, [FromBody] UpdateCarStatusDto updateDto)
    {
        var result = await _mediator.Send(new UpdateCarStatusCommand(carId, updateDto.IsRented));
        if (result)
        {
            return Ok();
        }
        return NotFound();
    }
}
