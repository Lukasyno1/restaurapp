using MediatR;

namespace Restaurapp.Contracts.Commands.Auth
{
    public class LoginCommand : IRequest<string>
    {
    }
}
