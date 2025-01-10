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

        //endpoints for customer    
        private readonly ICustomerRepository _customerInterface;

        public CustomerController(ICustomerRepository customerInterface)
        {
            _customerInterface = customerInterface;
        }
        // GET: api/Customer
        [HttpGet]
        public async Task<IEnumerable<Customer?>> GetAllAsync()
        {
            return await _customerInterface.GetAllAsync();
        }
        // GET: api/Customer/id 
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer?>> GetByIdAsync(int id)
        {
            var customer = await _customerInterface.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound("customer nort found");
            }
            return customer;
        }
        // POST: api/Customer
        [HttpPost]
        [Authorize]

        public async Task<Customer> CreateAsync([FromBody] CustomerDto customerDto)
        {
            var customer = Mapper.DtoMapper<Customer>(customerDto);
            return await _customerInterface.CreateAsync(customer);
        }

        // PUT: api/Customer/id
        [HttpPut("{id}")]
        [Authorize]

        public async Task<ActionResult<Customer>> UpdateAsync([FromRoute] int id, [FromBody] CustomerDto customerDto)
        {
            var customer = await _customerInterface.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound("customer not found");
            }

            customer = Mapper.DtoMapper(customerDto, customer);
            return await _customerInterface.UpdateAsync(customer);
        }
        // DELETE: api/Customer/id
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Customer>> DeleteAsync([FromRoute] int id)
        {
            var customer = await _customerInterface.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound("customer not found");
            }

            return await _customerInterface.DeleteAsync(customer);
        }
    }
}
