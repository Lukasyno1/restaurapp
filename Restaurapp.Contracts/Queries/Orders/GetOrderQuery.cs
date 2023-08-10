using MediatR;
using Restaurapp.Contracts.Dtos;

namespace Restaurapp.Contracts.Queries.Orders
{
    public class GetOrderQuery : IRequest<OrderDto>
    {
        public Guid Id { get; set; }
    }
}
