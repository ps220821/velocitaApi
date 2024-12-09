using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using velocitaApi.data;
using velocitaApi.Interfaces;
using velocitaApi.models;

namespace velocitaApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer?>> GetAllAsync()
        {
            return await _context.customer.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _context.customer.FindAsync(id);
        }

        public async Task<Customer> CreateAsync(Customer customer)
        {
            await _context.customer.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<ActionResult<Customer>> UpdateAsync(Customer customer)
        {
            _context.customer.Update(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> DeleteAsync(Customer customer)
        {
            _context.customer.Remove(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
    }
}
