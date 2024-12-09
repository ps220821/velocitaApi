using Microsoft.AspNetCore.Mvc;
using velocitaApi.models;


namespace velocitaApi.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category?> GetByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> CreateAsync(Category category);
        Task<ActionResult<Category>> UpdateAsync(Category category);
        Task<Category> DeleteAsync(Category category);
    }
}
