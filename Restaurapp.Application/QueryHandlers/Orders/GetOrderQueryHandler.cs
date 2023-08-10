using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurapp.Application.QueryHandlers.MenuItems;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Queries.Orders;
using Restaurapp.DataAccess;
using Restaurapp.Domain;

namespace Restaurapp.Application.QueryHandlers.Orders
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, OrderDto>
    {
        private readonly RContext _context;
        private readonly ILogger<GetOrderQueryHandler> _logger;

        public GetOrderQueryHandler(RContext context, ILogger<GetOrderQueryHandler> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<OrderDto> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var order = await _context.Orders.Include(o => o.MenuItems).SingleAsync(m => m.Id == request.Id);

                return new OrderDto
                {
                    Id = order.Id,
                    Price = order.Price,
                    Status = order.Status.ToString(),
                    UserId = order.UserId,
                    CreatedDate = order.CreatedDate,
                    ModifiedDate = order.ModifiedDate,
                    MenuItems = order.MenuItems.Select(m => m.MenuItemId).ToList(),
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return null;
            }
        }
    }
}
