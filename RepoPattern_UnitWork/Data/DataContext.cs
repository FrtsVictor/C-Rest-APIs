using Microsoft.EntityFrameworkCore;
using RepoPattern_UnitWork.Models;

namespace RepoPattern_UnitWork.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}