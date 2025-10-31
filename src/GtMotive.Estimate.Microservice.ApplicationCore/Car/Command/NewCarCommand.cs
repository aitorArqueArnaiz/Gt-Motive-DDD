using System;
using GtMotive.Estimate.Microservice.Domain.Entities;
using MediatR;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Cars.Command
{
    /// <summary>
    /// Create car command.
    /// </summary>
    public class NewCarCommand : IRequest<Car>
    {
        /// <summary>
        /// Gets or sets car brand.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets car Model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets car year.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets car registerning number.
        /// </summary>
        public int Registering { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets car is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets car created at.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets car updated at.
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
