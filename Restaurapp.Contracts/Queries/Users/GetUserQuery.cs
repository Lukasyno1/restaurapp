using MediatR;
using Restaurapp.Contracts.Dtos;

namespace Restaurapp.Contracts.Queries.Users
{
    public class GetUserQuery : IRequest<UserDto>
    {
        public Guid Id { get; set; }
    }
}
