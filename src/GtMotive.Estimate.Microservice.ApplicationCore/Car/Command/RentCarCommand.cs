using MediatR;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Cars.Command
{
    /// <summary>
    /// Rent car command.
    /// </summary>
    public class RentCarCommand : IRequest<bool>
    {
        /// <summary>
        /// Gets or sets car id.
        /// </summary>
        public string CarId { get; set; }

        /// <summary>
        /// Gets or sets registration number.
        /// </summary>
        public int Registration { get; set; }
    }
}
