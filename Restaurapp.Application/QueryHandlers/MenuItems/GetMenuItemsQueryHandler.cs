using MediatR;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Helpers;
using Restaurapp.Contracts.Queries.MenuItems;

namespace Restaurapp.Application.QueryHandlers.MenuItems
{
    public class GetMenuItemsQueryHandler : IRequestHandler<GetMenuItemsQuery, PagedResult<MenuItemDto>>
    {
        Task<PagedResult<MenuItemDto>> IRequestHandler<GetMenuItemsQuery, PagedResult<MenuItemDto>>.Handle(GetMenuItemsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
