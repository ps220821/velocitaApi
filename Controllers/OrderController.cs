using Microsoft.AspNetCore.Mvc;
using velocitaApi.Dtos.order;
using velocitaApi.Interfaces;
using velocitaApi.models;
using velocitaApi.Mappers;
using velocitaApi.data;
using Microsoft.AspNetCore.Authorization;


namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerInterface;
        private readonly ICarRepository _carRepository;

        public OrderController(IOrderRepository orderRepository, ICustomerRepository customerRepository, ICarRepository carRepository, ApplicationDbContext context)
        {
            _orderRepository = orderRepository;
            _customerInterface = customerRepository;
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Order>> GetOrders()
        {
            var orders = await _orderRepository.GetAllAsync();
            if (orders == null)
            {
                return NotFound("error: no orders found");
            }
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetById([FromRoute] int id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
            {
                return NotFound($"Order with ID {id} not found.");
            }
            return Ok(order);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Order>> CreateOrder([FromBody] OrderDto orderDto)
        {
            var mappedOrder = Mapper.DtoMapper<Order>(orderDto);

            if (orderDto.CarId.HasValue)
            {
                var car = await _carRepository.GetByIdAsync(orderDto.CarId.Value);
                if (car == null)
                {
                    return NotFound("Car not found.");
                }
                mappedOrder.carId = car.id;
                mappedOrder.Car = car;
            }

            var customer = await _customerInterface.GetByIdAsync(orderDto.CustomerId);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            mappedOrder.CustomerId = customer.id;
            mappedOrder.Customer = customer;

            var order = await _orderRepository.CreateAsync(mappedOrder);

            if (order == null)
            {
                return NotFound("Error while creating ");
            }
            return Ok(order);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateOrder([FromRoute] int id, [FromBody] OrderDto orderDto)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
            {
                return NotFound("Order not found");
            }

            var mappedOrder = Mapper.DtoMapper(orderDto, order);

            if (orderDto.CarId.HasValue)
            {
                var car = await _carRepository.GetByIdAsync(orderDto.CarId.Value);
                if (car == null) // Check if car is null
                {
                    return NotFound("Car not found."); // Return a 404 error with a message
                }
                mappedOrder.carId = car.id;
                mappedOrder.Car = car;
            }



            var customer = await _customerInterface.GetByIdAsync(orderDto.CustomerId);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            mappedOrder.CustomerId = customer.id;
            mappedOrder.Customer = customer;



            var updatedOrder = await _orderRepository.UpdateAsync(mappedOrder);
            if (updatedOrder == null)
            {
                return NotFound("Error while updating");
            }
            return Ok(updatedOrder);
        }

        [HttpDelete("{id}")]
        [Authorize]

        public async Task<ActionResult> DeleteOrder([FromRoute] int id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
            {
                return NotFound("Order not found");
            }
            var deletedOrder = await _orderRepository.DeleteAsync(order);
            if (deletedOrder == null)
            {
                return NotFound("Error while deleting");
            }
            return Ok(deletedOrder);
        }

    }
}
