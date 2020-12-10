using System.Collections.Generic;
using Application.DDD_API.Application.Dtos;
using Domain.DDD_API.Domain.Entities;

namespace Infrastructure.DDD_API.Infrastructure.CrossCuting.Interfaces
{
    public interface IProductMapper
    {
        Product MapperDtoEntity (ProductDto productDto);
        IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products);
        ProductDto MaperEntityToDto(Product product);
    }
}