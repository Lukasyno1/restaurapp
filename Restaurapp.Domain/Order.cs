namespace Restaurapp.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public OrderStatus Status { get; set; }
        
        public decimal Price { get; set; }

        public Guid UserId { get; set; }

        public User? User { get; set; }

        public IEnumerable<OrderUpdate> OrderUpdates { get; set; }

        public IEnumerable<OrderMenuItem> MenuItems { get; set; }

        public void UpdateStatus(OrderStatus newStatus)
        {
            this.Status = newStatus;
            this.OrderUpdates.ToList().Add(new OrderUpdate { Id = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, OrderId = this.Id });
        }
    }
}
