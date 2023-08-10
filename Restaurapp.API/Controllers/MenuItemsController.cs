using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurapp.Contracts.Queries.MenuItems;

namespace Restaurapp.API.Controllers
{
    [ApiController]
    [Route("MenuItems")]
    public class MenuItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenuItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMenuItems([FromQuery] GetMenuItemsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuItem(Guid id)
        {
            var query = new GetMenuItemQuery { Id = id };
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
