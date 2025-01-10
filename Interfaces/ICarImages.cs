using Microsoft.AspNetCore.Mvc;

public interface ICarImages
{
    Task<CarImages?> GetByIdAsync(int id);
    Task<IEnumerable<CarImages>> GetAllAsync();
    Task<CarImages> CreateAsync(CarImages carImages);
    Task<ActionResult<CarImages>> UpdateAsync(CarImages carImages);
    Task<ActionResult<CarImages>> DeleteAsync(CarImages carImages);
}