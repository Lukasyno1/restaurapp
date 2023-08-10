using MediatR;
using Restaurapp.Contracts.Commands.Orders;

namespace Restaurapp.Application.CommandHandlers.Orders
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, bool>
    {
        public Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
