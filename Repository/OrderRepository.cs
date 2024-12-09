using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.Interfaces;
using velocitaApi.models;

namespace velocitaApi.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order?>> GetAllAsync()
        {
            // include car and customer

            return await _context.order
            .Include(o => o.Car)
            .Include(o => o.Customer)
            .ToListAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _context.order
            .Include(c => c.Car)
            .Include(c => c.Customer)
            .FirstOrDefaultAsync(o => o.id == id);
        }

        public async Task<Order> CreateAsync(Order order)
        {
            await _context.order.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<ActionResult<Order>> UpdateAsync(Order order)
        {
            _context.order.Update(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<Order> DeleteAsync(Order order)
        {
            _context.order.Remove(order);
            await _context.SaveChangesAsync();
            return order;
        }
    }
}
