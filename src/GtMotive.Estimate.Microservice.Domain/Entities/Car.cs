using System;

namespace GtMotive.Estimate.Microservice.Domain.Entities
{
    /// <summary>
    /// car class.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="brand">the car brand.</param>
        /// <param name="model">the car model.</param>
        /// <param name="registration">registration number.</param>
        /// <param name="year">year.</param>
        public Car(string brand, string model, int registration, int year)
        {
            Id = Guid.NewGuid().ToString();
            Brand = brand;
            Model = model;
            Registration = registration;
            IsAvaible = true;
            Year = year;
        }

        /// <summary>
        /// Gets or sets car Id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets car brand.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets car model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets car year.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets manufacturing date.
        /// </summary>
        public int Registration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets if the car is available for renting.
        /// </summary>
        public bool IsAvaible { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets if the car is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets car creation date.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets car update date.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Rent car.
        /// </summary>
        /// <param name="clientId">Client id.</param>
        public void Rent()
        {
            if (!IsAvaible)
            {
                throw new InvalidOperationException("The car isn't avaibled for renting");
            }

            IsAvaible = false;
        }

        /// <summary>
        /// Return car.
        /// </summary>
        public void Return()
        {
            if (!IsAvaible)
            {
                throw new InvalidOperationException("The car isn't rented");
            }

            IsAvaible = true;
        }
    }
}
