using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using velocitaApi.data;
using velocitaApi.Dtos.CarOption;
using velocitaApi.Interfaces;
using velocitaApi.Mappers;
using velocitaApi.models;

[ApiController]
[Route("api/[controller]")]
public class CarOptionController : ControllerBase
{
    private readonly ICarOptionRepository _carOptionRepository;

    public CarOptionController(ICarOptionRepository carOptionRepository)
    {
        _carOptionRepository = carOptionRepository;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddCarOption(CarOptionDto carOptionDto)
    {
        bool checkExist = await _carOptionRepository.CheckIFExist(carOptionDto.CarId, carOptionDto.OptionId);
        if (checkExist)
        {
            return BadRequest("Option is already added to the car");
        }
        var mappedCarOption = Mapper.MapCreate<CarOption>(carOptionDto);
        await _carOptionRepository.AddCarOption(mappedCarOption);

        return Ok("Car option added successfully");
    }

    [HttpDelete("car/{carId}/option/{optionId}")]
    [Authorize]
    public async Task<IActionResult> DeleteCarOption([FromRoute] int carId, [FromRoute] int optionId)
    {
        var carOption = await _carOptionRepository.FindCarOption(carId, optionId);
        if (carOption == null)
        {
            return BadRequest("Car option doesn't exist");
        }

        await _carOptionRepository.DeleteCarOption(carOption);
        return Ok("Car option deleted successfully");
    }
}