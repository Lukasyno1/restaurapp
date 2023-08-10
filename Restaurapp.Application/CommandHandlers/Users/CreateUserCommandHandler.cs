using MediatR;
using Restaurapp.Contracts.Commands.Users;

namespace Restaurapp.Application.CommandHandlers.Users
{
    internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
