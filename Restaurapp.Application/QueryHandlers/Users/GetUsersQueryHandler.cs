using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Helpers;
using Restaurapp.Contracts.Queries.Users;
using Restaurapp.DataAccess;

namespace Restaurapp.Application.QueryHandlers.Users
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, PagedResult<UserDto>>
    {
        private readonly RContext _context;

        public GetUsersQueryHandler(RContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var totalCount = await _context.Users.CountAsync();
            var orders = await _context.Users.OrderBy(u => u.LastName).Skip(request.PageNumber * request.PageSize).Take(request.PageSize).ToListAsync();

            return new PagedResult<UserDto>
            {
                Data = orders.Select(o => new UserDto
                {
                    Id = o.Id,
                    FirstName= o.FirstName,
                    LastName= o.LastName,
                    CreatedDate= o.CreatedDate,
                    ModifiedDate= o.ModifiedDate,
                    DateOfBirth = o.DateOfBirth,
                    PhoneNumber = o.PhoneNumber
                }),
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                TotalCount = totalCount
            };
        }
    }
}
