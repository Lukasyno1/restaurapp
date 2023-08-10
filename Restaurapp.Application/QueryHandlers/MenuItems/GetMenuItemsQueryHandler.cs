using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Helpers;
using Restaurapp.Contracts.Queries.MenuItems;
using Restaurapp.DataAccess;

namespace Restaurapp.Application.QueryHandlers.MenuItems
{
    public class GetMenuItemsQueryHandler : IRequestHandler<GetMenuItemsQuery, PagedResult<MenuItemDto>>
    {
        private readonly RContext _context;

        public GetMenuItemsQueryHandler(RContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<MenuItemDto>> Handle(GetMenuItemsQuery request, CancellationToken cancellationToken)
        {
            var totalCount = await _context.MenuItems.CountAsync();
            var menuItems = await _context.MenuItems.OrderBy(m => m.Name).Skip(request.PageNumber * request.PageSize).Take(request.PageSize).ToListAsync();

            return new PagedResult<MenuItemDto>
            {
                Data = menuItems.Select(menuItem => new MenuItemDto
                {
                    Id = menuItem.Id,
                    Name = menuItem.Name,
                    Price = menuItem.Price,
                    Category = menuItem.Category.ToString()
                }),
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                TotalCount = totalCount
            };
        }
    }
}
