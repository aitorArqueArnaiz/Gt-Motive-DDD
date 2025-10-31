using System.Threading.Tasks;
using FluentAssertions;
using GtMotive.Estimate.Microservice.ApplicationCore.Repository;
using GtMotive.Estimate.Microservice.Domain.Entities;
using GtMotive.Estimate.Microservice.Infrastructure.Context;
using GtMotive.Estimate.Microservice.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace GtMotive.Estimate.Microservice.Tests.Integration
{
    public class CarInfrastructureTests
    {
        private readonly ServiceProvider _serviceProvider;

        public CarInfrastructureTests()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("InfrastructureTestBBDD"));

            services.AddScoped<ICarRepository, CarRepository>();

            _serviceProvider = services.BuildServiceProvider();

            using var scope = _serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
        }

        [Fact]
        public async Task CreateNewCarPersitanceTest()
        {
            // arrange
            using var scope = _serviceProvider.CreateScope();
            var carRepository = scope.ServiceProvider.GetRequiredService<ICarRepository>();
            var car = new Car("Seat", "Ibiza", 2020, 123456);

            // act
            await carRepository.AddAsync(car);

            // assert
            var result = await carRepository.GetByIdAsync(car.Id);
            result.Should().NotBeNull();
            result.Brand.Should().Be(car.Brand);
            result.Model.Should().Be(car.Model);
            result.Registration.Should().Be(car.Registration);
        }
    }
}
