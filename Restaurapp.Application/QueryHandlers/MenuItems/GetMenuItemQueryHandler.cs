using MediatR;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Queries.MenuItems;

namespace Restaurapp.Application.QueryHandlers.MenuItems
{
    public class GetMenuItemQueryHandler : IRequestHandler<GetMenuItemQuery, MenuItemDto>
    {
        public async Task<MenuItemDto> Handle(GetMenuItemQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
