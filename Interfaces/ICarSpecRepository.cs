using Microsoft.AspNetCore.Mvc;
using velocitaApi.models;

public interface ICarSpecRepository
{
    Task<CarSpec?> GetByIdAsync(int id);
    Task<IEnumerable<CarSpec>> GetAllAsync();
    Task<IActionResult> CreateAsync(CarSpec carSpec);
    Task<ActionResult> UpdateAsync(CarSpec carSpec);
    Task<ActionResult> DeleteAsync(CarSpec carSpec);

    Task<CarSpec> FindByCarId(int carId);
}


