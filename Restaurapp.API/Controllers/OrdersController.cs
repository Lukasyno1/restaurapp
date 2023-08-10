using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurapp.Contracts.Commands.Orders;
using Restaurapp.Contracts.Queries.Orders;

namespace Restaurapp.API.Controllers
{
    [ApiController]
    [Route("Orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders([FromQuery] GetOrdersQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(Guid id)
        {
            var query = new GetOrderQuery { Id = id };
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? Ok() : StatusCode(500);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? Ok() : StatusCode(500);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletOrder([FromBody] DeleteOrderCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? Ok() : StatusCode(500);
        }
    }
}
