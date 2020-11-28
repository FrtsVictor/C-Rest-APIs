using Microsoft.EntityFrameworkCore;
using Net5_InMemoryDb.Models;

namespace Net5_InMemoryDb.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
         : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } //table
        public DbSet<Category> Categories { get; set; } //table

    }
}