using Microsoft.AspNetCore.Mvc;
using velocitaApi.Mappers;
using Microsoft.AspNetCore.Authorization;
using velocitaApi.models;
using velocitaApi.Dtos.CarOption;
using velocitaApi.Interfaces;

namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarSpecController : ControllerBase
    {
        private readonly ICarSpecRepository _carSpecRepository;
        private readonly ICarRepository _carRepository;
        public CarSpecController(ICarSpecRepository carSpecRepository, ICarRepository carRepository)
        {
            _carSpecRepository = carSpecRepository;
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CarSpec>> GetCarSpecs()
        {
            var carSpecs = await _carSpecRepository.GetAllAsync();
            if (carSpecs == null)
            {
                return NotFound();
            }
            return Ok(carSpecs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarSpec>> GetById([FromRoute] int id)
        {
            var carSpec = await _carSpecRepository.GetByIdAsync(id);
            if (carSpec == null)
            {
                throw new KeyNotFoundException($"CarSpec with ID {id} not found.");
            }
            return Ok(carSpec);
        }


        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CarSpec>> CreateCarSpec([FromBody] CarSpecDto carSpecDto)
        {
            var car = await _carRepository.GetByIdAsync(carSpecDto.CarId);
            if (car == null)
            {
                return BadRequest("Car not found");
            }
            var mappedCar = Mapper.DtoMapper<CarSpec>(carSpecDto);
            mappedCar.Car = car;

            var createdCarSpec = await _carSpecRepository.CreateAsync(mappedCar);
            if (createdCarSpec == null)
            {
                return BadRequest("CarSpec not created");
            }
            return Ok(createdCarSpec);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<CarSpec>> UpdateCarSpec([FromRoute] int id, [FromBody] CarSpecDto carSpecDto)
        {
            var carSpec = await _carSpecRepository.GetByIdAsync(id);
            if (carSpec == null)
            {
                return NotFound($"CarSpec with ID {id} not found.");
            }
            var mappedCarSpec = Mapper.DtoMapper(carSpecDto, carSpec);
            mappedCarSpec.Car = carSpec.Car;

            var updatedCarSpec = await _carSpecRepository.UpdateAsync(mappedCarSpec);

            if (updatedCarSpec == null)
            {
                return BadRequest("CarSpec not updated");
            }
            return Ok(updatedCarSpec);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCarSpec([FromRoute] int id)
        {
            var carSpec = await _carSpecRepository.GetByIdAsync(id);
            if (carSpec == null)
            {
                throw new KeyNotFoundException($"CarSpec with ID {id} not found.");
            }

            var deletedCarSpec = await _carSpecRepository.DeleteAsync(carSpec);
            if (deletedCarSpec == null)
            {
                return BadRequest("CarSpec not deleted");
            }

            return Ok("CarSpec deleted");
        }



        // find by carId
        [HttpGet("car/{carId}")]
        public async Task<ActionResult<CarSpec>> FindByCarId([FromRoute] int carId)
        {
            var carSpec = await _carSpecRepository.FindByCarId(carId);
            if (carSpec == null)
            {
                return NotFound($"CarSpec with Car ID {carId} not found.");
            }
            return Ok(carSpec);
        }
    }
}
