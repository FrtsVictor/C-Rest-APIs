using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Domain.DDD_API.Domain.Entities;

namespace Infrastructure.DDD_API.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedDate") != null))
            {

                if (entry.State == EntityState.Added) //if i'm creating new register, it will get DateTimeNow
                {
                    entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified) //to certificate i don't do nothing when updating 
                {
                    entry.Property("CreatedDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}