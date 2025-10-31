using AutoMapper;
using GtMotive.Estimate.Microservice.ApplicationCore.Interfaces.Dtos;
using GtMotive.Estimate.Microservice.Domain.Entities;

namespace GtMotive.Estimate.Microservice.Api.Mappers
{
    public class CarRentingProfile : Profile
    {
        public CarRentingProfile()
        {
            CreateMap<Car, CarRentingDto>();
        }
    }
}
