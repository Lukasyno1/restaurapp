using MediatR;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Helpers;

namespace Restaurapp.Contracts.Queries.Users
{
    public class GetUsersQuery : PagedRequest<PagedResult<UserDto>>
    {
    }
}
