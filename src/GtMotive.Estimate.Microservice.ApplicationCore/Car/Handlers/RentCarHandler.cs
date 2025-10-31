using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repository;
using MediatR;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Cars.Handlers
{
    /// <summary>
    /// Rent car handler.
    /// </summary>
    public class RentCarHandler : IRequestHandler<Command.RentCarCommand, bool>
    {
        private readonly ICarRepository _carRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentCarHandler"/> class.
        /// </summary>
        /// <param name="carRepository">car repository.</param>
        public RentCarHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        /// <summary>
        /// Create car handler.
        /// </summary>
        /// <param name="request">Create car command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>car id.</returns>
        public async Task<bool> Handle(Command.RentCarCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new InvalidOperationException("The request is null");
            }

            var car = await _carRepository.GetByIdAsync(request.CarId);

            if (car == null || !car.IsAvaible)
            {
                return false;
            }

            // Check if client had already rented a car
            var carRented = (await _carRepository.GetAllAsync())
                .Where(v => !v.IsAvaible && v.Registration == request.Registration);

            if (carRented.Any())
            {
                return false;
            }

            car.IsAvaible = false;
            car.Registration = request.Registration;
            await _carRepository.UpdateAsync(car);

            return true;
        }
    }
}
