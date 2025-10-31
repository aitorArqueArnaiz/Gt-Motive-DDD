namespace GtMotive.Estimate.Microservice.ApplicationCore.Interfaces.Dtos
{
    /// <summary>
    /// car DTO.
    /// </summary>
    public class CarRentingDto
    {
        /// <summary>
        /// Gets or sets car id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets brand car.
        /// </summary
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets model car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets manufacturing date car.
        /// </summary>
        public string ManufacturingDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets if car is avaible.
        /// </summary>
        public bool Avaible { get; set; }

        /// <summary>
        /// Gets or sets client id.
        /// </summary>
        public string ClientId { get; set; }
    }
}
