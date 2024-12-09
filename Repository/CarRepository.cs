
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.Interfaces;
using velocitaApi.models;


namespace velocitaApi.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;
        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            var cars = await _context.car.ToListAsync();
            return cars;
        }

        public async Task<Car?> GetByIdAsync(int id)
        {
            var car = await _context.car
            .Include(c => c.Brand)
            .Include(c => c.Category)
            .Include(c => c.CarSpecs)
            .FirstOrDefaultAsync(c => c.id == id);

            return car;
        }

        public async Task<Car> CreateAsync(Car car)
        {

            var createReq = await _context.car.AddAsync(car);
            await _context.SaveChangesAsync();
            return createReq.Entity;
        }

        public async Task<ActionResult<Car>> UpdateAsync(Car car)
        {
            var updateCar = _context.car.Update(car);
            await _context.SaveChangesAsync();
            return updateCar.Entity;
        }

        public async Task<ActionResult<Car>> DeleteAsync(Car car)
        {

            var removeReq = _context.car.Remove(car);
            await _context.SaveChangesAsync();

            return removeReq.Entity;
        }
    }
}
