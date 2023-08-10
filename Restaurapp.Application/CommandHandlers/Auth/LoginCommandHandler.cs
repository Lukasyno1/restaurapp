using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Restaurapp.Application.QueryHandlers.Users;
using Restaurapp.Contracts.Commands.Auth;
using Restaurapp.DataAccess;

namespace Restaurapp.Application.CommandHandlers.Auth
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly RContext _context;
        private readonly ILogger<LoginCommandHandler> _logger;
        private readonly IConfiguration _configuration;

        public LoginCommandHandler(RContext context, ILogger<LoginCommandHandler> logger, IConfiguration configuration)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }
        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = _context.Users.FirstOrDefault(u => u.Login == request.Login && u.Password == request.Password);

            if(user == null)
            {
                return null;
            }

            return _configuration["XApiKey"];
        }
    }
}
