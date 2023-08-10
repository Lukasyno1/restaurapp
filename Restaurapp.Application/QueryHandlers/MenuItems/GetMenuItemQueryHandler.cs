using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Queries.MenuItems;
using Restaurapp.DataAccess;

namespace Restaurapp.Application.QueryHandlers.MenuItems
{
    public class GetMenuItemQueryHandler : IRequestHandler<GetMenuItemQuery, MenuItemDto>
    {
        private readonly RContext _context;
        private readonly ILogger<GetMenuItemQueryHandler> _logger;

        public GetMenuItemQueryHandler(RContext context, ILogger<GetMenuItemQueryHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<MenuItemDto> Handle(GetMenuItemQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var menuItem = await _context.MenuItems.SingleAsync(m => m.Id == request.Id);

                return new MenuItemDto
                {
                    Id = menuItem.Id,
                    Name = menuItem.Name,
                    Price = menuItem.Price,
                    Category = menuItem.Category.ToString()
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
