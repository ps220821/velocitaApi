using Microsoft.AspNetCore.Mvc;
using velocitaApi.Interfaces;
using velocitaApi.models;
using velocitaApi.Dtos.customer;
using velocitaApi.Mappers;
using Microsoft.AspNetCore.Authorization;

namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerInterface;

        public CustomerController(ICustomerRepository customerInterface)
        {
            _customerInterface = customerInterface;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer?>> GetAllAsync()
        {
            return await _customerInterface.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _customerInterface.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<Customer> CreateAsync([FromBody] CustomerDto customerDto)
        {
            var customer = Mapper.MapCreate<Customer>(customerDto);
            return await _customerInterface.CreateAsync(customer);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Customer>> UpdateAsync([FromRoute] int id, [FromBody] CustomerDto customerDto)
        {
            var customer = await _customerInterface.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            customer = Mapper.MapUpdate(customerDto, customer);
            return await _customerInterface.UpdateAsync(customer);
        }

        [HttpDelete("{id}")]
        [Authorize]

        public async Task<ActionResult<Customer>> DeleteAsync([FromRoute] int id)
        {
            var customer = await _customerInterface.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return await _customerInterface.DeleteAsync(customer);
        }
    }
}
