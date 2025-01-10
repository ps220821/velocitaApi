using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using velocitaApi.Dtos.car;
using velocitaApi.Interfaces;
using velocitaApi.Mappers;
using velocitaApi.models;

namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly IBrandRepository _brandRepository;

        public CarController(ICarRepository carRepository, IBrandRepository brandrepository)
        {
            _carRepository = carRepository;
            _brandRepository = brandrepository;
        }

        [HttpGet]
        public async Task<ActionResult<Car>> GetCars()
        {
            var cars = await _carRepository.GetAllAsync();
            if (cars == null)
            {
                return NotFound();
            }
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetById([FromRoute] int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if (car == null)
            {
                return NotFound($"Car with ID {id} not found.");
            }

            return Ok(car);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Car>> CreateCar([FromBody] CarDto carDto)

        {
            var brand = await _brandRepository.GetByIdAsync(carDto.BrandId);
            if (brand == null)
            {
                return NotFound("Brand not found");
            }

            var mappedCar = Mapper.DtoMapper<Car>(carDto);

            var createdCar = await _carRepository.CreateAsync(mappedCar);

            if (createdCar == null)
            {
                return BadRequest("Car not created");
            }

            return CreatedAtAction(nameof(GetById), new { id = createdCar.id }, createdCar);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Car>> UpdateCar([FromRoute] int id, [FromBody] CarDto carDto)
        {
            // Find the existing car by its ID
            var existingCar = await _carRepository.GetByIdAsync(id);

            if (existingCar == null)
            {
                return NotFound("Car not found");
            }

            if (existingCar.Brand?.id != carDto.BrandId)
            {
                var brand = await _brandRepository.GetByIdAsync(carDto.BrandId);
                if (brand == null)
                {
                    return NotFound("Brand not found");
                }
                existingCar.Brand = brand;
                existingCar.BrandId = carDto.BrandId;
            }
            var mappedCar = Mapper.DtoMapper(carDto, existingCar);

            var updatedCar = await _carRepository.UpdateAsync(mappedCar);
            if (updatedCar == null)
            {
                return NotFound("Car not updated");
            }

            return Ok(updatedCar);
        }


        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Car>> DeleteCar([FromRoute] int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if (car == null)
            {
                return NotFound("Car not found");

            }
            var deletedCar = await _carRepository.DeleteAsync(car);
            if (deletedCar == null)
            {
                return BadRequest("car is not deleted");
            }
            return car;
        }
    }
}
