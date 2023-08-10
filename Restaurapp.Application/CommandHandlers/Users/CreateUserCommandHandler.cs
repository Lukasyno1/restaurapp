using MediatR;
using Microsoft.Extensions.Logging;
using Restaurapp.Application.QueryHandlers.MenuItems;
using Restaurapp.Contracts.Commands.Users;
using Restaurapp.DataAccess;
using Restaurapp.Domain;
using Restaurapp.Domain.Providers;

namespace Restaurapp.Application.CommandHandlers.Users
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly RContext _context;
        private readonly ILogger<GetMenuItemQueryHandler> _logger;
        private readonly IDateTimeProvider _dateTimeProvider;

        public CreateUserCommandHandler(RContext context, ILogger<GetMenuItemQueryHandler> logger, IDateTimeProvider dateTimeProvider)
        {
            _context = context;
            _logger = logger;
            _dateTimeProvider = dateTimeProvider;
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var now = _dateTimeProvider.GetCurrentUtc();
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = now,
                    ModifiedDate = now,
                    DateOfBirth = request.DateOfBirth,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Login = request.Login,
                    Password = request.Password,
                    PhoneNumber = request.PhoneNumber,
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return false;
            }
        }
    }
}
