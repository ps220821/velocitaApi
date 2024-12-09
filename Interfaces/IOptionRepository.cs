using Microsoft.AspNetCore.Mvc;
using velocitaApi.models;

namespace velocitaApi.Interfaces
{
    public interface IOptionRepository
    {
        Task<IEnumerable<Option?>> GetAllAsync();
        Task<Option?> GetByIdAsync(int id);
        Task<Option> CreateAsync(Option option);
        Task<ActionResult<Option>> UpdateAsync(Option option);
        Task<Option> DeleteAsync(Option option);
    }
}
