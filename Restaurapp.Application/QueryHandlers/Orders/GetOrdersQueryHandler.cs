using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Helpers;
using Restaurapp.Contracts.Queries.Orders;
using Restaurapp.DataAccess;
using Restaurapp.Domain;

namespace Restaurapp.Application.QueryHandlers.Orders
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, PagedResult<OrderDto>>
    {
        private readonly RContext _context;

        public GetOrdersQueryHandler(RContext context)
        {
            _context = context;
        }
        public async Task<PagedResult<OrderDto>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            var totalCount = await _context.Orders.CountAsync();
            var orders = await _context.Orders.Include(o => o.MenuItems).OrderBy(m => m.Status).Skip(request.PageNumber * request.PageSize).Take(request.PageSize).ToListAsync();

            return new PagedResult<OrderDto>
            {
                Data = orders.Select(o => new OrderDto
                {
                    Id = o.Id,
                    Price = o.Price,
                    Status = o.Status.ToString(),
                    UserId = o.UserId,
                    CreatedDate = o.CreatedDate,
                    ModifiedDate = o.ModifiedDate,
                    MenuItems = o.MenuItems.Select(m => m.MenuItemId).ToList(),
                }),
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                TotalCount = totalCount
            };
        }
    }
}
