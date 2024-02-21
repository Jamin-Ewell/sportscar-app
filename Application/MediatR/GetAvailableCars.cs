using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Repository.IRepository;
using MediatR;

namespace Application.MediatR;

public record GetAvailableCarsQuery : IRequest<IEnumerable<Car>>;

public class GetAvailableCarsQueryHandler : IRequestHandler<GetAvailableCarsQuery, IEnumerable<Car>>
{

    private readonly ICarRepository _carRepository;

    public GetAvailableCarsQueryHandler(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }
    public async Task<IEnumerable<Car>> Handle(GetAvailableCarsQuery request, CancellationToken cancellationToken)
    {
        return await _carRepository.GetAvailableCarsAsync();
    }
}

    

