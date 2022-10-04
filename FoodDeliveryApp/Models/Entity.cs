
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp.Models
{
    public class Entity : IdentityDbContext<ApplicationUser,Role,int>
    {
        public Entity() { }
        public Entity(DbContextOptions<Entity> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .HasKey(o => new { o.OrderId, o.ItemId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Order> orders { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
    }
}
