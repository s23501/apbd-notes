using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Kolokwium.Data
{
    public class ChangeMeContext : DbContext
    {
        public DbSet<ChangeMe1> ChangeMe1 { get; set; }
        public DbSet<ChangeMe2> ChangeMe2 { get; set; }
        public DbSet<ChangeMe3> ChangeMe3 { get; set; }
        public DbSet<ChangeMe4> ChangeMe4 { get; set; }
        public DbSet<ChangeMe5> ChangeMe5 { get; set; }

        public ChangeMeContext(DbContextOptions options) : base(options)
        {
        }

        protected ChangeMeContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChangeMe1>().HasData(new List<ChangeMe1>
            {
                 new ChangeMe1
                {

                }
                
            });

            modelBuilder.Entity<ChangeMe2>().HasData(new List<ChangeMe2>
            {
                 new ChangeMe2
                {

                }
                

            });

            modelBuilder.Entity<ChangeMe3>().HasData(new List<ChangeMe3>
            {
                 new ChangeMe3
                {

                }
                
            });

            modelBuilder.Entity<ChangeMe4>().HasData(new List<ChangeMe4>
            {
                 new ChangeMe4
                {

                }
                
            });

            modelBuilder.Entity<ChangeMe5>().HasData(new List<ChangeMe5>
            {
                 new ChangeMe5
                {

                }
                
            });

        }

    }
}
