namespace Restaurapp.Contracts.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }

        public string Status { get; set; }

        public decimal Price { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public IEnumerable<Guid> MenuItems { get; set; } = new List<Guid>();
    }
}
