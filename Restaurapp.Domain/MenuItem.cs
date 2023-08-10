namespace Restaurapp.Domain
{
    public class MenuItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public MenuItemCategory Category { get; set; }

        public decimal Price { get; set; }

        public string ImageFileName { get; set; }
    }
}
