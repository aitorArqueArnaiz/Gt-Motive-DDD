using System;
using System.Threading;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repository;
using MediatR;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Cars.Handlers
{
    /// <summary>
    /// Return car handler.
    /// </summary>
    public class RefundCarHandler : IRequestHandler<Command.RefundCarCommand, bool>
    {
        private readonly ICarRepository _carRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCarHandler"/> class.
        /// </summary>
        /// <param name="carRepository">car repository.</param>
        public RefundCarHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        /// <summary>
        /// Return car handler.
        /// </summary>
        /// <param name="request">Return car command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True if the operation is sucessfull.</returns>
        public async Task<bool> Handle(Command.RefundCarCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new InvalidOperationException("command is is null");
            }

            var car = await _carRepository.GetByIdAsync(request.CarId);

            if (car == null || car.IsAvaible)
            {
                return false;
            }

            car.IsAvaible = true;
            await _carRepository.UpdateAsync(car);

            return true;
        }
    }
}
