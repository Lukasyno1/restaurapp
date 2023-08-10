using MediatR;

namespace Restaurapp.Contracts.Helpers
{
    public class PagedRequest<T> : IRequest<T>
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }
    }
}
