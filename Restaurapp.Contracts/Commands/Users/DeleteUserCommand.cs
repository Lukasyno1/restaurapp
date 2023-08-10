using MediatR;

namespace Restaurapp.Contracts.Commands.Users
{
    public class DeleteUserCommand : IRequest<bool>
    {
    }
}
