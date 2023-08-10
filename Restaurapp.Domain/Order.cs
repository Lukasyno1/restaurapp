using Restaurapp.Domain.Providers;

namespace Restaurapp.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public OrderStatus Status { get; set; }

        public decimal Price { get; set; }

        public Guid UserId { get; set; }

        public User? User { get; set; }
        
        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public IEnumerable<OrderMenuItem> MenuItems { get; set; }

        public void UpdateStatus(OrderStatus newStatus, IDateTimeProvider dateTimeProvider)
        {
            this.Status = newStatus;
            this.ModifiedDate = dateTimeProvider.GetCurrentUtc();
        }
    }
}
