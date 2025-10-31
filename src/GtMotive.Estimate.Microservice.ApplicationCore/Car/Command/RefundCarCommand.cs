using MediatR;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Cars.Command
{
    /// <summary>
    /// Return car command.
    /// </summary>
    public class RefundCarCommand : IRequest<bool>
    {
        /// <summary>
        /// Gets or sets car Id.
        /// </summary>
        public string CarId { get; set; }
    }
}
