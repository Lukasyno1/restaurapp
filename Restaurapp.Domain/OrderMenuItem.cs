namespace Restaurapp.Domain
{
    public class OrderMenuItem
    {
        public Guid OrderId { get; set; }

        public Order? Order { get; set; }

        public Guid MenuItemId { get; set; }

        public MenuItem? MenuItem { get; set; }
    }
}
