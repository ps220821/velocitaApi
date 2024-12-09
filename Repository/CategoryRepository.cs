using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.Interfaces;
using velocitaApi.models;

namespace velocitaApi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.category.ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _context.category.FindAsync(id);
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await _context.category.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
        public async Task<ActionResult<Category>> UpdateAsync(Category category)
        {
            _context.category.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> DeleteAsync(Category category)
        {
            _context.category.Remove(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
