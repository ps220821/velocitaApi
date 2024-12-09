using Microsoft.AspNetCore.Mvc;
using velocitaApi.models;

namespace velocitaApi.Interfaces
{
    public interface ICarRepository
    {
        Task<Car?> GetByIdAsync(int id);
        Task<IEnumerable<Car>> GetAllAsync();
        Task<Car> CreateAsync(Car car);
        Task<ActionResult<Car>> UpdateAsync(Car car);
        Task<ActionResult<Car>> DeleteAsync(Car car);
    }
}
