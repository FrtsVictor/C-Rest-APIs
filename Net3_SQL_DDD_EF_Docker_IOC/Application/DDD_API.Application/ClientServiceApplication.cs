using System.Collections.Generic;
using Application.DDD_API.Application.Dtos;
using Application.DDD_API.Application.Interface;
using DDD_API.Domain.Core.Interfaces.Services;
using Infrastructure.DDD_API.Infrastructure.CrossCuting.Interfaces;

namespace Application.DDD_API.Application
{
    public class ClientServiceApplication : IClientServiceApplication
    {
        private readonly IClientService clientService;
        private readonly IClientMapper mapperClient;
        public void Add(ClientDto clientDto)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClientDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ClientDto GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(ClientDto clientDto)
        {
            throw new System.NotImplementedException();
        }

        public void Update(ClientDto clientDto)
        {
            throw new System.NotImplementedException();
        }
    }
}