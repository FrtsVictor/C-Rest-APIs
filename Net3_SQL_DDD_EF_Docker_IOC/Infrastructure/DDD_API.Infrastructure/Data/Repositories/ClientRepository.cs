using DDD_API.Domain.Core.Interfaces.Repositories;
using Domain.DDD_API.Domain.Entities;
using Infrastructure.DDD_API.Infrastructure.Data;

namespace DDD_API.Infrastructure.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {

        private readonly SqlContext sqlContext;

        public ClientRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

    }
}