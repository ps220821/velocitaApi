using Microsoft.AspNetCore.Mvc;
using velocitaApi.models;

namespace velocitaApi.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order?>> GetAllAsync();
        Task<Order?> GetByIdAsync(int id);
        Task<Order> CreateAsync(Order order);
        Task<ActionResult<Order>> UpdateAsync(Order order);
        Task<Order> DeleteAsync(Order order);
    }
}
