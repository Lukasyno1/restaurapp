using MediatR;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Helpers;
using Restaurapp.Contracts.Queries.Users;

namespace Restaurapp.Application.QueryHandlers.Users
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, PagedResult<UserDto>>
    {
        public Task<PagedResult<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
