using System.Collections.Generic;
using Application.DDD_API.Application.Dtos;
using Domain.DDD_API.Domain.Entities;

namespace Application.DDD_API.Application.Interface.Mappers
{
    public interface IProductMapper
    {
        Product MapperDtoEntity (ProductDto productDto);
        IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products);
        ProductDto MapperEntityToDto(Product product);
    }
}