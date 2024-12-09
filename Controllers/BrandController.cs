using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using velocitaApi.Dtos.brand;
using velocitaApi.Interfaces;
using velocitaApi.models;
namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;
        public BrandController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }



        [HttpGet]
        public async Task<ActionResult<Brand>> GetBrands()
        {
            var brands = await _brandRepository.GetAllAsync();
            if (brands == null)
            {
                return NotFound();
            }
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetById([FromRoute] int id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);

            if (brand == null)
            {
                throw new KeyNotFoundException($"Brand with ID {id} not found.");
            }

            return Ok();
        }
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrand([FromBody] BrandDto brandDto)
        {
            var createdBrand = await _brandRepository.CreateAsync(brandDto);
            if (createdBrand == null)
            {
                return BadRequest("Brand not created");
            }
            return CreatedAtAction(nameof(GetById), new { id = createdBrand.id }, createdBrand);
        }
        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult<Brand>> UpdateBrand([FromRoute] int id, [FromBody] BrandDto brandDto)
        {
            var updatedBrand = await _brandRepository.UpdateAsync(id, brandDto);
            if (updatedBrand == null)
            {
                return BadRequest("Brand not updated");
            }
            return Ok(updatedBrand);
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Brand>> DeleteBrand([FromRoute] int id)
        {
            var deletedBrand = await _brandRepository.DeleteAsync(id);
            if (deletedBrand == null)
            {
                return BadRequest("Brand not deleted");
            }
            return Ok(deletedBrand);
        }

    }
}
