using DDD_API.Domain.Core.Interfaces.Repositories;
using DDD_API.Domain.Core.Interfaces.Services;
using Domain.DDD_API.Domain.Entities;

namespace DDD_API.Domain.Services
{
    public class ClientService : BaseService<Client>, IClientService
    {
        private readonly IClientRepository clientRepository;

        public ClientService(IClientRepository clientRepository) : base(clientRepository)
        {
            this.clientRepository = clientRepository;
        }
    }
}