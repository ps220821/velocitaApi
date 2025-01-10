
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.Dtos.brand;
using velocitaApi.Interfaces;
using velocitaApi.Mappers;
using velocitaApi.models;


namespace velocitaApi.Repository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _context;

        public BrandRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Brand>> GetAllAsync()
        {
            var brands = await _context.brand.ToListAsync();
            return brands;
        }

        public async Task<Brand?> GetByIdAsync(int id)
        {
            var brand = await _context.brand.FindAsync(id);
            return await _context.brand.FindAsync(id);
        }

        public async Task<Brand> CreateAsync(BrandDto brandDto)
        {

            var mappedBrand = Mapper.DtoMapper<Brand>(brandDto);
            var createReq = await _context.brand.AddAsync(mappedBrand);
            await _context.SaveChangesAsync();

            return mappedBrand;  // Return the created brand if successful
        }


        public async Task<Brand> UpdateAsync(int id, BrandDto brandDto)
        {
            var brand = await _context.brand.FindAsync(id);

            if (brand == null)
            {
                return null;
            }

            brand.Name = brandDto.Name;
            brand.Description = brandDto.Description;
            brand.Url = brandDto.Url;
            brand.Country = brandDto.Country;

            _context.brand.Update(brand);
            await _context.SaveChangesAsync();

            return brand;
        }

        public async Task<Brand> DeleteAsync(int id)
        {
            var brand = await _context.brand.Include(b => b.Cars).FirstOrDefaultAsync(b => b.id == id);
            if (brand == null)
            {
                return null;
            }

            _context.brand.Remove(brand);
            await _context.SaveChangesAsync();

            return brand;
        }
    }
}
