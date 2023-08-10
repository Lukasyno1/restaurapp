using MediatR;

namespace Restaurapp.Contracts.Commands.Orders
{
    public class DeleteOrderCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
