using GtMotive.Estimate.Microservice.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Repository
{
    /// <summary>
    /// ICarRepository interface.
    /// </summary>
    public interface ICarRepository
    {
        /// <summary>
        /// Add car method.
        /// </summary>
        /// <param name="car">Car dto.</param>
        /// <returns>Void.</returns>
        Task AddAsync(Car car);

        /// <summary>
        /// Get all cars method.
        /// </summary>
        /// <returns>Enumerable of cars.</returns>
        Task<IEnumerable<Car>> GetAllAsync();

        /// <summary>
        /// Get car by id method.
        /// </summary>
        /// <param name="id">car unique identifier.</param>
        /// <returns>car dto object.</returns>
        Task<Car> GetByIdAsync(string id);

        /// <summary>
        /// Get available cars method.
        /// </summary>
        /// <returns>List of available cars for rent.</returns>
        Task<IEnumerable<Car>> GetAvaibleCarsForRentAsync();

        /// <summary>
        /// Update car method.
        /// </summary>
        /// <param name="car">Car object dto.</param>
        /// <returns>void.</returns>
        Task UpdateAsync(Car car);
    }
}
