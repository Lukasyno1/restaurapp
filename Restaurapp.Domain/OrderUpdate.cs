namespace Restaurapp.Domain
{
    public class OrderUpdate
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid OrderId { get; set; }

        public Order? Order { get; set; }
    }
}
