using MediatR;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Queries.Orders;

namespace Restaurapp.Application.QueryHandlers.Orders
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, OrderDto>
    {
        public Task<OrderDto> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
