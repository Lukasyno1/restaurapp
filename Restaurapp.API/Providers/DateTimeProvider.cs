using Restaurapp.Domain.Providers;

namespace Restaurapp.API.Providers
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentUtc() => DateTime.UtcNow;
    }
}
