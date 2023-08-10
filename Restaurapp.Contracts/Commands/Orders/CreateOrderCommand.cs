using MediatR;

namespace Restaurapp.Contracts.Commands.Orders
{
    public class CreateOrderCommand : IRequest<bool>
    {
    }
}
