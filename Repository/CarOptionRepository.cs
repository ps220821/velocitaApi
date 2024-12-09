using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.Interfaces;
using velocitaApi.models;


namespace velocitaApi.Repository
{
    public class CarOptionRepository : ICarOptionRepository
    {
        private readonly ApplicationDbContext _context;
        public CarOptionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AddCarOption(CarOption carOption)
        {
            await _context.CarOptions.AddAsync(carOption);
            await _context.SaveChangesAsync();
            return new OkObjectResult("Car option added successfully");
        }

        public async Task<bool> CheckIFExist(int carId, int optionId)
        {
            bool exists = await _context.CarOptions.AnyAsync(x => x.CarId == carId && x.OptionId == optionId);
            return exists;
        }

        public async Task<IActionResult> DeleteCarOption(CarOption carOption)
        {
            _context.CarOptions.Remove(carOption);
            await _context.SaveChangesAsync();
            return new OkObjectResult("Car option deleted successfully");
        }

        public async Task<CarOption> FindCarOption(int carId, int optionId)
        {
            var carOption = await _context.CarOptions.FirstOrDefaultAsync(x => x.CarId == carId && x.OptionId == optionId);
            if (carOption == null)
            {
                return null;
            }
            return carOption;
        }

        public async Task<IEnumerable<CarOptionCustom>> FindByCarId(int carId)
        {
            var carOptions = await _context.CarOptions
                                    .Where(x => x.CarId == carId)
                                    .Include(co => co.Option)
                                    .Select(co => new CarOptionCustom
                                    {
                                        Id = co.id,                    // Mapping the fields to CarOptionCustom
                                        Option = co.Option,             // Including the Option object
                                        Available = co.Available,
                                        Description = co.Description
                                    })
                                    .ToListAsync();
            return carOptions;
        }

    }
}

