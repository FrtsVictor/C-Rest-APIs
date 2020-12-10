using System.Collections.Generic;
using System.Linq;
using Application.DDD_API.Application.Dtos;
using Domain.DDD_API.Domain.Entities;
using Infrastructure.DDD_API.Infrastructure.CrossCuting.Interfaces;

namespace Infrastructure.DDD_API.Infrastructure.CrossCuting.Map
{
    public class ClientMapper : IClientMapper
    {
        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            var client = new Client()
            {
                Id = clientDto.Id,
                Name = clientDto.Name,
                LastName = clientDto.LastName,
                Email = clientDto.Email
            };
            return client;
        }

        public ClientDto MaperEntityToDto(Client client)
        {
            var clientDto = new ClientDto()
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email
            };
            return clientDto;
        }

        public IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new ClientDto  { Id = c.Id,
                                                           Name = c.Name,
                                                           LastName = c.LastName,
                                                           Email = c.Email });
            return dto;
        }
    }
}