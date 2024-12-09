using Microsoft.AspNetCore.Mvc;
using velocitaApi.Interfaces;
using velocitaApi.models;

namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarDetailsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarSpecRepository _carSpecRepository;
        private readonly ICarOptionRepository _carOptionRepository;

        public CarDetailsController(ICarRepository carRepository, ICarSpecRepository carSpecRepository, ICarOptionRepository carOptionRepository)
        {
            _carRepository = carRepository;
            _carSpecRepository = carSpecRepository;
            _carOptionRepository = carOptionRepository;
        }


        [HttpGet("car/{id}")]
        public async Task<ActionResult<CarReq>> GetCars([FromRoute] int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if (car == null)
            {
                return NotFound("Car not found");
            }


            var carSpec = await _carSpecRepository.FindByCarId(id);
            if (carSpec == null)
            {
                return NotFound("CarSpec not found");
            }

            var carOptions = await _carOptionRepository.FindByCarId(id);
            if (carOptions == null)
            {
                return NotFound("CarOptions not found");
            }

            CarReq carReq = new CarReq
            {
                Car = car,
                CarSpecs = carSpec,
                CarOptions = carOptions.ToList()
            };

            return Ok(carReq);
        }
    }
}

