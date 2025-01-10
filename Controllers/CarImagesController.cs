using Microsoft.AspNetCore.Mvc;
using velocitaApi.Interfaces;
using velocitaApi.Mappers;

namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarImagesController : ControllerBase
    {
        private readonly ICarImages _carImages;
        private readonly ICarRepository _carRepository;

        public CarImagesController(ICarImages carImages, ICarRepository carRepository)
        {
            this._carImages = carImages;
            this._carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<CarImages?>> GetAllAsync()
        {
            return await _carImages.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<CarImages?> GetByIdAsync(int id)
        {
            return await _carImages.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<CarImages> CreateAsync([FromBody] CarImagesDto carImagesDto)
        {
            var car = await _carRepository.GetByIdAsync(carImagesDto.CarId);
            if (car == null)
            {
                throw new Exception("Car not found");
            }

            var carImages = Mapper.DtoMapper<CarImages>(carImagesDto);
            carImages.Car = car;

            return await _carImages.CreateAsync(carImages);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CarImages>> UpdateAsync([FromRoute] int id, [FromBody] CarImagesDto carImagesDto)
        {
            var car = await _carRepository.GetByIdAsync(carImagesDto.CarId);
            if (car == null)
            {
                throw new Exception("Car not found");
            }

            var carImages = await _carImages.GetByIdAsync(id);
            if (carImages == null)
            {
                return NotFound();
            }

            carImages = Mapper.DtoMapper(carImagesDto, carImages);
            carImages.Car = car;

            return await _carImages.UpdateAsync(carImages);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CarImages>> DeleteAsync([FromRoute] int id)
        {
            var carImages = await _carImages.GetByIdAsync(id);

            if (carImages == null)
            {
                return NotFound();
            }
            return await _carImages.DeleteAsync(carImages);
        }
    }
}