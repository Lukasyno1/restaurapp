using MediatR;
using Restaurapp.Domain;

namespace Restaurapp.Contracts.Commands.Orders
{
    public class UpdateOrderCommand : IRequest<bool>
    {
        public Guid Id { get; set; }

        public OrderStatus Status { get; set; }
    }
}
