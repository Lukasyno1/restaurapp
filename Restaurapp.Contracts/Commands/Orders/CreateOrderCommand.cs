using MediatR;

namespace Restaurapp.Contracts.Commands.Orders
{
    public class CreateOrderCommand : IRequest<bool>
    {
        public Guid UserId { get; set; }

        public IEnumerable<Guid> MenuItemsIds { get; set; }
    }
}
