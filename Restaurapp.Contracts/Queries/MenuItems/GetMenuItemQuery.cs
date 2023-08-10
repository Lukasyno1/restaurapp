using MediatR;
using Restaurapp.Contracts.Dtos;

namespace Restaurapp.Contracts.Queries.MenuItems
{
    public class GetMenuItemQuery : IRequest<MenuItemDto>
    {
        public Guid Id { get; set; }
    }
}
