using velocitaApi.models;
using velocitaApi.Dtos.brand;
namespace velocitaApi.Interfaces
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand?> GetByIdAsync(int id);
        Task<Brand> CreateAsync(BrandDto BrandDto);
        Task<Brand> UpdateAsync(int id, BrandDto brandDto);
        Task<Brand> DeleteAsync(int id);
    }
}
