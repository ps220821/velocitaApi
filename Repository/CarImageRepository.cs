

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.Migrations;
using velocitaApi.models;

namespace velocitaApi.Repository
{
    public class CarImageRepository : ICarImages
    {
        private readonly ApplicationDbContext _context;
        public CarImageRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CarImages?>> GetAllAsync()
        {
            return await _context.carImages.ToListAsync(); ;
        }

        public async Task<CarImages?> GetByIdAsync(int id)
        {
            return await _context.carImages.FirstOrDefaultAsync(c => c.id == id);
        }

        public async Task<ActionResult<CarImages>> UpdateAsync(CarImages carImages)
        {
            _context.carImages.Update(carImages);
            await _context.SaveChangesAsync();
            return carImages;
        }
        public async Task<CarImages> CreateAsync(CarImages carImages)
        {
            _context.carImages.Add(carImages);
            await _context.SaveChangesAsync();
            return carImages;
        }

        public async Task<ActionResult<CarImages>> DeleteAsync(CarImages carImages)
        {
            _context.Remove(carImages);
            await _context.SaveChangesAsync();
            return carImages;
        }
    }
}