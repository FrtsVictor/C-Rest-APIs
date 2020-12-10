using System.Collections.Generic;
using Application.DDD_API.Application.Dtos;
using Domain.DDD_API.Domain.Entities;

namespace Infrastructure.DDD_API.Infrastructure.CrossCuting.Interfaces
{
    public interface IClientMapper
    {
        Client MapperDtoToEntity (ClientDto clientDto);
        IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients);
        ClientDto MaperEntityToDto(Client client);
    }
}