using System;
using System.Threading;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Cars.Command;
using GtMotive.Estimate.Microservice.ApplicationCore.Repository;
using GtMotive.Estimate.Microservice.Domain.Entities;
using MediatR;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Cars.Handlers
{
    /// <summary>
    /// Create car handler.
    /// </summary>
    public class CreateCarHandler : IRequestHandler<NewCarCommand, Car>
    {
        private readonly ICarRepository _carRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCarHandler"/> class.
        /// </summary>
        /// <param name="carRepository">car repository.</param>
        public CreateCarHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        /// <summary>
        /// Create car handler.
        /// </summary>
        /// <param name="request">Create car command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>car id.</returns>
        public async Task<Car> Handle(NewCarCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new InvalidOperationException("creta new car command empty");
            }

            // Create car
            var car = new Car(request.Brand, request.Model, request.Registering, request.Year);

            await _carRepository.AddAsync(car);
            return car;
        }
    }
}
