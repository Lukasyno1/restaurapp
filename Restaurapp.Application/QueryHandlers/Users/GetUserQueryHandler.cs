using MediatR;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Queries.Users;

namespace Restaurapp.Application.QueryHandlers.Users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
