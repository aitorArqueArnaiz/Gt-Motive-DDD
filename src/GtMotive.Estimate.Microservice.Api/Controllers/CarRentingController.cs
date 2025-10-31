using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GtMotive.Estimate.Microservice.Api.Filters;
using GtMotive.Estimate.Microservice.ApplicationCore.Cars.Command;
using GtMotive.Estimate.Microservice.ApplicationCore.Cars.Queries;
using GtMotive.Estimate.Microservice.ApplicationCore.Interfaces.Dtos;
using GtMotive.Estimate.Microservice.Domain.Entities;
using GtMotive.Estimate.Microservice.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GtMotive.Estimate.Microservice.Api.Controllers
{
    [ApiController]
    [Route("api/service/cars")]
    [ServiceFilter(typeof(BusinessExceptionFilter))]
    public class CarRentingController : ControllerBase
    {
        private readonly IAppLogger<Car> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CarRentingController(IAppLogger<Car> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("new")]
        public async Task<IActionResult> Create([FromBody] NewCarCommand command)
        {
            try
            {
                var car = await _mediator.Send(command);
                _logger.LogInformation($"car with id {car.Id} has created sucessfully.");
                return Ok(_mapper.Map<CarRentingDto>(car));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> RefundCar([FromQuery] string id)
        {
            var query = new RefundCarCommand { CarId = id };
            if (string.IsNullOrEmpty(id))
            {
                throw new InvalidOperationException("car identifier is null and must have a value");
            }

            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("list")]
        public async Task<IActionResult> List()
        {
            var cars = await _mediator.Send(new ListCarsQuery());
            return Ok(_mapper.Map<List<CarRentingDto>>(cars));
        }

        [HttpPost("rent")]
        public async Task<IActionResult> Rent([FromBody] RentCarCommand command)
        {
            if (command == null)
            {
                throw new InvalidOperationException("Command is null");
            }

            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
