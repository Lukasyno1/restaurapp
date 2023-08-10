using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurapp.Application.QueryHandlers.Orders;
using Restaurapp.Contracts.Commands.Orders;
using Restaurapp.DataAccess;
using Restaurapp.Domain;
using Restaurapp.Domain.Providers;

namespace Restaurapp.Application.CommandHandlers.Orders
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly RContext _context;
        private readonly ILogger<CreateOrderCommandHandler> _logger;
        private readonly IDateTimeProvider _dateTimeProvider;

        public CreateOrderCommandHandler(RContext context, ILogger<CreateOrderCommandHandler> logger, IDateTimeProvider dateTimeProvider)
        {
            _context = context;
            _logger = logger;
            _dateTimeProvider = dateTimeProvider;
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var selectedMenuItems = await _context.MenuItems.Where(mi => request.MenuItemsIds.Contains(mi.Id)).Select(mi => new
                {
                    mi.Id,
                    mi.Price
                }).ToListAsync();

                var now = _dateTimeProvider.GetCurrentUtc();
                var id = Guid.NewGuid();

                var order = new Order
                {
                    Id = id,
                    CreatedDate = now,
                    ModifiedDate = now,
                    MenuItems = selectedMenuItems.Select(m => new OrderMenuItem
                    {
                        MenuItemId = m.Id,
                        OrderId = id
                    }).ToList(),
                    Price = selectedMenuItems.Sum(m => m.Price),
                    Status = OrderStatus.Created,
                    UserId = request.UserId,
                };

                _context.Add(order);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.ToString());
                return false;
            }
        }
    }
}
