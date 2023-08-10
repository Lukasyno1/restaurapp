namespace Restaurapp.Domain.Providers
{
    public interface IDateTimeProvider
    {
        public DateTime GetCurrentUtc();
    }
}
