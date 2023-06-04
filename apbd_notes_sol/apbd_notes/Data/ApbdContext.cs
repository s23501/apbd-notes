using apbd_notes.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace apbd_notes.Data
{
    public class ApbdContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pastry> Pastries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPastry> OrderPastries { get; set; }

        public ApbdContext(DbContextOptions options) : base(options)
        {
        }
        protected ApbdContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ClientConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new PastryConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderPastryConfiguration());

            modelBuilder.Entity<Order>().HasData(new List<Order>
            {
                new Order
                {
                    ID = 1,
                    AcceptedAt = DateTime.Parse("2023-05-28"),
                    FulfilledAt = DateTime.Parse("2023-05-29"),
                    Comments = "Lorem ipsum ...",
                    ClientID = 1,
                    EmployeeID = 2
                },
                new Order
                {
                    ID = 2,
                    AcceptedAt = DateTime.Parse("2023-05-31"),
                    FulfilledAt = DateTime.Parse("2023-06-01"),
                    Comments = "Lorem ipsum ...",
                    ClientID = 1,
                    EmployeeID = 1
                },
                new Order
                {
                    ID = 3,
                    AcceptedAt = DateTime.Parse("2023-06-01"),
                    FulfilledAt = null,
                    Comments = null,
                    ClientID = 2,
                    EmployeeID = 1
                }
            });



        }
    }
}
