using DDD_API.Domain.Core.Interfaces.Repositories;
using Domain.DDD_API.Domain.Entities;
using Infrastructure.DDD_API.Infrastructure.Data;

namespace DDD_API.Infrastructure.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly SqlContext sqlContext;

        public ProductRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}