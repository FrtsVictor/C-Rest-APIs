using Microsoft.EntityFrameworkCore;

namespace DDD_API.Infrastructure.Data
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
    }
}