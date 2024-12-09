using Microsoft.AspNetCore.Mvc;
using velocitaApi.models;

namespace velocitaApi.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer?>> GetAllAsync();
        Task<Customer?> GetByIdAsync(int id);
        Task<Customer> CreateAsync(Customer customer);
        Task<ActionResult<Customer>> UpdateAsync(Customer customer);
        Task<Customer> DeleteAsync(Customer customer);
    }
}
