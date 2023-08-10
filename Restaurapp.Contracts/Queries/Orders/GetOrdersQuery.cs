using MediatR;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Helpers;

namespace Restaurapp.Contracts.Queries.Orders
{
    public class GetOrdersQuery : PagedRequest<PagedResult<OrderDto>>
    {
    }
}
