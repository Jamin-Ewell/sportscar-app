// Application/MediatR/Commands/UpdateCarStatusCommand.cs

using Infrastructure.Repository.IRepository;
using MediatR;

namespace Application.MediatR;

public record UpdateCarStatusCommand(int CarId, bool NewStatus) : IRequest<bool>;

public class UpdateCarStatusCommandHandler : IRequestHandler<UpdateCarStatusCommand, bool>
{
    private readonly ICarRepository _carRepository;

    public UpdateCarStatusCommandHandler(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public async Task<bool> Handle(UpdateCarStatusCommand request, CancellationToken cancellationToken)
    {
        var car = await _carRepository.FindByIdAsync(request.CarId);

        if (car == null)
        {
            return false; 
        }

        if (request.NewStatus)
        {
            car.BookCar();
        }
        else
        {
            car.ReturnCar(); 
        }

        await _carRepository.UpdateAsync(car);

        return true;
    }
}
