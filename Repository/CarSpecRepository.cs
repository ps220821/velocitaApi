using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.models;

namespace velocitaApi.Repository
{
    public class CarSpecRepository : ICarSpecRepository
    {
        private readonly ApplicationDbContext _context;
        public CarSpecRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CarSpec>> GetAllAsync()
        {
            return await _context.CarSpecs.ToListAsync();
        }

        public async Task<CarSpec?> GetByIdAsync(int id)
        {
            return await _context.CarSpecs.FirstOrDefaultAsync(carspec => carspec.Id == id);
        }

        public async Task<IActionResult> CreateAsync(CarSpec carSpec)
        {
            await _context.CarSpecs.AddAsync(carSpec);
            await _context.SaveChangesAsync();
            return new OkObjectResult("Car option added successfully");
        }
        public async Task<ActionResult> UpdateAsync(CarSpec carSpec)
        {
            _context.CarSpecs.Update(carSpec);
            await _context.SaveChangesAsync();
            return new OkObjectResult("Car option updated successfully");
        }

        public async Task<ActionResult> DeleteAsync(CarSpec carSpec)
        {
            _context.CarSpecs.Remove(carSpec);
            await _context.SaveChangesAsync();
            return new OkObjectResult("Car option deleted successfully");
        }

        public async Task<CarSpec> FindByCarId(int carId)
        {
            var carspec = await _context.CarSpecs.FirstOrDefaultAsync(carspec => carspec.CarId == carId);
            return carspec;
        }
    }
}