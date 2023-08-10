using MediatR;
using Restaurapp.Contracts.Commands.Auth;

namespace Restaurapp.Application.CommandHandlers.Auth
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
