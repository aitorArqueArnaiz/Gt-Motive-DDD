using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Cars.Queries;
using GtMotive.Estimate.Microservice.ApplicationCore.Repository;
using GtMotive.Estimate.Microservice.Domain.Entities;
using MediatR;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Cars.Handlers
{
    /// <summary>
    /// Get avaibles cars handler.
    /// </summary>
    public class ListCarsHandler : IRequestHandler<ListCarsQuery, IEnumerable<Car>>
    {
        private readonly ICarRepository _carRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCarsHandler"/> class.
        /// </summary>
        /// <param name="carRepository">carRepository.</param>
        public ListCarsHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        /// <summary>
        /// Handler.
        /// </summary>
        /// <param name="request">GetAvaiblescarsQuery.</param>
        /// <param name="cancellationToken">cancellationToken.</param>
        /// <returns>void.</returns>
        public async Task<IEnumerable<Car>> Handle(ListCarsQuery request, CancellationToken cancellationToken)
        {
            return await _carRepository.GetAvaibleCarsForRentAsync();
        }
    }
}
