using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using GtMotive.Estimate.Microservice.ApplicationCore.Cars.Command;
using GtMotive.Estimate.Microservice.ApplicationCore.Cars.Handlers;
using GtMotive.Estimate.Microservice.ApplicationCore.Cars.Queries;
using GtMotive.Estimate.Microservice.ApplicationCore.Repository;
using GtMotive.Estimate.Microservice.Domain.Entities;
using Moq;
using Xunit;

namespace GtMotive.Estimate.Microservice.UnitTests.Handlers
{
    public class CarsHandlerTests
    {
        private readonly Mock<ICarRepository> _carRepository;

        public CarsHandlerTests()
        {
            _carRepository = new Mock<ICarRepository>();
        }

        [Fact]
        public async Task GetAvailableListOfcarsForRent()
        {
            // arrange
            var availablecars = new List<Car>
            {
                new("Seat", "Ibiza", 123456, 2015)
            };
            _carRepository.Setup(repo => repo.GetAvaibleCarsForRentAsync()).ReturnsAsync(availablecars);

            // act
            var query = new ListCarsHandler(_carRepository.Object);
            var result = await query.Handle(new ListCarsQuery(), CancellationToken.None);

            // assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(availablecars);
        }

        [Fact]
        public async Task RentCar()
        {
            // arrange
            var car = new Car("seat", "ibiza", 123456, 2015);
            _carRepository.Setup(repo => repo.GetByIdAsync(It.IsAny<string>())).ReturnsAsync(car);

            // act
            var command = new RentCarHandler(_carRepository.Object);
            var result = await command.Handle(new RentCarCommand(), CancellationToken.None);

            // assert
            result.Should().BeTrue();
        }
    }
}
