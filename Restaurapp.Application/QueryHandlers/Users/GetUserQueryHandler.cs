using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurapp.Application.QueryHandlers.MenuItems;
using Restaurapp.Contracts.Dtos;
using Restaurapp.Contracts.Queries.Users;
using Restaurapp.DataAccess;

namespace Restaurapp.Application.QueryHandlers.Users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        private readonly RContext _context;
        private readonly ILogger<GetUserQueryHandler> _logger;

        public GetUserQueryHandler(RContext context, ILogger<GetUserQueryHandler> logger)
        {
            _context = context;
           _logger = logger;
        }

        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _context.Users.SingleAsync(m => m.Id == request.Id);

                return new UserDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    CreatedDate = user.CreatedDate,
                    ModifiedDate = user.ModifiedDate,
                    DateOfBirth = user.DateOfBirth,
                    PhoneNumber = user.PhoneNumber
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return null;
            }
        }
    }
}
