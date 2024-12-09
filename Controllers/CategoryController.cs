using Microsoft.AspNetCore.Mvc;
using velocitaApi.Interfaces;
using velocitaApi.models;
using velocitaApi.Dtos.category;
using velocitaApi.Mappers;
using Microsoft.AspNetCore.Authorization;


namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Category>> GetCategories()
        {
            var categories = await _categoryRepository.GetAllAsync();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetById([FromRoute] int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with ID {id} not found.");
            }
            return Ok(category);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Category>> CreateCategory([FromBody] CategoryDto categoryDto)
        {
            var mappedCategory = Mapper.MapCreate<Category>(categoryDto);

            var createdCategory = await _categoryRepository.CreateAsync(mappedCategory);

            if (createdCategory == null)
            {
                return BadRequest("Category not created");
            }
            return Ok(createdCategory);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Category>> UpdateCategory([FromRoute] int id, [FromBody] CategoryDto categoryDto)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound("Category not found");
            }
            var mappedOption = Mapper.MapUpdate(categoryDto, category);
            var updatedCategory = await _categoryRepository.UpdateAsync(mappedOption);

            if (updatedCategory == null)
            {
                return BadRequest("Category not updated");
            }
            return Ok(updatedCategory);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            // Probeer de categorie op te halen.
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound($"Category with ID {id} not found.");
            }

            // Verwijder de categorie.
            var deletedCategory = await _categoryRepository.DeleteAsync(category);

            // Controleer of de verwijdering geslaagd is.
            if (deletedCategory == null)
            {
                return StatusCode(500, "Failed to delete the category. Please try again.");
            }

            return Ok(deletedCategory); // Retourneer de verwijderde categorie.
        }
    }
}
