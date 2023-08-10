using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurapp.Contracts.Commands.Orders;
using Restaurapp.DataAccess;
using Restaurapp.Domain;
using Restaurapp.Domain.Providers;

namespace Restaurapp.Application.CommandHandlers.Orders
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, bool>
    {
        private readonly RContext _context;
        private readonly ILogger<UpdateOrderCommandHandler> _logger;
        private readonly IDateTimeProvider _dateTimeProvider;

        public UpdateOrderCommandHandler(RContext context, ILogger<UpdateOrderCommandHandler> logger, IDateTimeProvider dateTimeProvider)
        {
            _context = context;
            _logger = logger;
            _dateTimeProvider = dateTimeProvider;
        }

        public async Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var order = await _context.Orders.SingleAsync(o => o.Id == request.Id);
                order.UpdateStatus(request.Status, _dateTimeProvider);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return false;
            }
        }
    }
}
