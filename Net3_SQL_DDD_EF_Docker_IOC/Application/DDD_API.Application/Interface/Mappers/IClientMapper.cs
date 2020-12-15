using System.Collections.Generic;
using Application.DDD_API.Application.Dtos;
using Domain.DDD_API.Domain.Entities;

namespace Application.DDD_API.Application.Interface.Mappers
{
    public interface IClientMapper
    {
        Client MapperDtoToEntity(ClientDto clientDto);
        IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients);
        ClientDto MaperEntityToDto(Client client);
    }
}