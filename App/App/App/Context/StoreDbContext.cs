using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Context
{
    public partial class StoreDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Status> Statuses { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<ProductOrder> ProductOrders { get; set; }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Name=ConnectionStrings:Default");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(e =>
            {
                e.Property(x => x.Price).HasPrecision(10, 2);

                e.HasData(new List<Product>
                {
                    new Product { Id = 1, Name = "Product 1", Price = 10.00m },
                    new Product { Id = 2, Name = "Product 2", Price = 20.00m },
                });
            });

            modelBuilder.Entity<Client>()
                .HasData(new List<Client>
                {
                    new Client { Id = 1, FirstName = "Client 1", LastName = "Client 1" },
                    new Client { Id = 2, FirstName = "Client 2", LastName = "Client 2" },
                });

            modelBuilder.Entity<Status>()
                .HasData(new List<Status>
                {
                    new Status { Id = 1, Name = "Status 1" },
                    new Status { Id = 2, Name = "Status 2" },
                });

            modelBuilder.Entity<Order>()
                .HasData(new List<Order>
                {
                    new Order { Id = 1, CreatedAt = DateTime.Now, ClientId = 1, StatusId = 1 },
                    new Order { Id = 2, CreatedAt = DateTime.Now, ClientId = 2, StatusId = 2 },
                });

            modelBuilder.Entity<ProductOrder>()
                .HasData(new List<ProductOrder> {
                    new ProductOrder { ProductId = 1, OrderId = 1, Amount = 1 },
                    new ProductOrder { ProductId = 2, OrderId = 1, Amount = 2 },
                });
        }
    }
}
