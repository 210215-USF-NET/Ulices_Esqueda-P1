using Microsoft.EntityFrameworkCore;
using SModels;

namespace SDL
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions options) : base(options)
        {
        }

        protected StoreDBContext()
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<LocationVisited> LocationVisted { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreInventory> StoreInventories { get; set; }
        public DbSet<TrackOrder> TrackOrders { get; set; }
    }
}