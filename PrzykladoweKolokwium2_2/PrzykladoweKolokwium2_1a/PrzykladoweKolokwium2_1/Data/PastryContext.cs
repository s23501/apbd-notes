﻿using Microsoft.EntityFrameworkCore;
using PrzykladoweKolokwium2_1.Models;

namespace PrzykladoweKolokwium2_1.Data
{
    public class PastryContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pastry> Pastries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPastry> OrderPastries { get; set; }

        public PastryContext(DbContextOptions options) : base(options)
        {
        }

        protected PastryContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new List<Client>
            {
                new Client {
                    ID = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski"
                },
                new Client {
                    ID = 2,
                    FirstName = "Anna",
                    LastName = "Nowak"
                }
            });

            modelBuilder.Entity<Employee>().HasData(new List<Employee>
            {
                new Employee {
                    ID = 1,
                    FirstName = "Adam",
                    LastName = "Nowak"
                },
                new Employee {
                    ID = 2,
                    FirstName = "Aleksandra",
                    LastName = "Wiśniewska"
                }
            });

            modelBuilder.Entity<Pastry>().HasData(new List<Pastry>
            {
                new Pastry
                {
                    ID = 1,
                    Name = "Drożdzówka",
                    Price = 3.3M,
                    Type = "A"
                },
                new Pastry
                {
                    ID = 2,
                    Name = "Babka cytrynowa",
                    Price = 21.23M,
                    Type = "B"
                },
                new Pastry
                {
                    ID = 3,
                    Name = "Jagodzianka",
                    Price = 7.2M,
                    Type = "A"
                }
            });

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

            modelBuilder.Entity<OrderPastry>().HasData(new List<OrderPastry>
            {
                new OrderPastry
                {
                    OrderID = 1,
                    PastryID = 1,
                    Amount = 3,
                },
                new OrderPastry
                {
                    OrderID = 1,
                    PastryID = 3,
                    Amount = 4,
                    Comments = "Lorem ipsum ..."
                },
                new OrderPastry
                {
                    OrderID = 2,
                    PastryID = 2,
                    Amount = 2
                },
                new OrderPastry
                {
                    OrderID = 2,
                    PastryID = 1,
                    Amount = 12
                }
            });
        }
    }
}
