using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using velocitaApi.Dtos.option;
using velocitaApi.Interfaces;
using velocitaApi.Mappers;
using velocitaApi.models;

namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OptionController : ControllerBase
    {
        private readonly IOptionRepository _optionRepository;
        public OptionController(IOptionRepository optionRepository)
        {
            _optionRepository = optionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Option>> GetOptions()
        {
            var options = await _optionRepository.GetAllAsync();
            if (options == null)
            {
                return NotFound("error: no options found");
            }
            return Ok(options);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Option>> GetById([FromRoute] int id)
        {
            var option = await _optionRepository.GetByIdAsync(id);
            if (option == null)
            {
                return NotFound($"Option with ID {id} not found.");
            }
            return Ok(option);
        }

        [HttpPost]
        [Authorize]

        public async Task<ActionResult<Option>> CreateOption([FromBody] OptionDto optionDto)
        {
            var mappedOption = Mapper.DtoMapper<Option>(optionDto);
            var newOption = await _optionRepository.CreateAsync(mappedOption);

            return CreatedAtAction(nameof(GetById), new { id = newOption.id }, newOption);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Option>> UpdateOption([FromRoute] int id, [FromBody] OptionDto optionDto)
        {
            var option = await _optionRepository.GetByIdAsync(id);
            if (option == null)
            {
                return NotFound($"Option with ID {id} not found.");
            }

            var mappedOption = Mapper.DtoMapper(optionDto, option);
            var updatedOption = await _optionRepository.UpdateAsync(mappedOption);

            if (updatedOption == null)
            {
                return NotFound($"error while updating");
            }
            return Ok(updatedOption);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Option>> DeleteOption([FromRoute] int id)
        {
            var option = await _optionRepository.GetByIdAsync(id);
            if (option == null)
            {
                return NotFound($"Option with ID {id} not found.");
            }
            var deletedOption = await _optionRepository.DeleteAsync(option);
            return Ok(deletedOption);
        }
    }
}
