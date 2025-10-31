using System.Collections.Generic;
using GtMotive.Estimate.Microservice.Domain.Entities;
using MediatR;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Cars.Queries
{
    /// <summary>
    /// MediatR query request for listing cars.
    /// </summary>
    public class ListCarsQuery : IRequest<IEnumerable<Car>>
    {
    }
}
