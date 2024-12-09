using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.Interfaces;
using velocitaApi.models;

namespace velocitaApi.Repository
{
    public class OptionRepository : IOptionRepository
    {
        private readonly ApplicationDbContext _context;
        public OptionRepository(ApplicationDbContext context) { 
            _context = context;
        }

        public async Task<IEnumerable<Option?>> GetAllAsync()
        {
            return await _context.options.ToListAsync();
        }

        public async Task<Option?> GetByIdAsync(int id)
        {
            return await _context.options.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<Option> CreateAsync(Option option)
        {
            await _context.options.AddAsync(option);
            await _context.SaveChangesAsync();
            return option;
        }

        public async Task<ActionResult<Option>> UpdateAsync(Option option)
        {
            _context.options.Update(option);
            await _context.SaveChangesAsync();
            return new ActionResult<Option>(option);
        }

        public async Task<Option> DeleteAsync(Option option)
        {
            _context.options.Remove(option);
            await _context.SaveChangesAsync();
            return option;
        }
    }
}
