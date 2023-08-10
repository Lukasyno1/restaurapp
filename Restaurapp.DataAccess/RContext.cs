using Microsoft.EntityFrameworkCore;
using Restaurapp.Domain;

namespace Restaurapp.DataAccess
{
    public class RContext : DbContext
    {
        public RContext(DbContextOptions<RContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<OrderMenuItem> OrderMenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderMenuItem>()
                .HasKey(omi => new { omi.OrderId, omi.MenuItemId});

            modelBuilder.Entity<OrderMenuItem>()
                .HasOne(omi => omi.Order)
                .WithMany(o => o.MenuItems)
                .HasForeignKey(o => o.OrderId);
        }
    }
}
