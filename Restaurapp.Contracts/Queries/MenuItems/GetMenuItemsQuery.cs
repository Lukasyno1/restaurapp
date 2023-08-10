using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Helpers;

namespace Restaurapp.Contracts.Queries.MenuItems
{
    public class GetMenuItemsQuery : PagedRequest<PagedResult<MenuItemDto>>
    {
    }
}
