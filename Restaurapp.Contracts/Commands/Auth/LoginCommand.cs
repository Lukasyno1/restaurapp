using MediatR;

namespace Restaurapp.Contracts.Commands.Auth
{
    public class LoginCommand : IRequest<string>
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}
