using System.Collections.Generic;
using System.Linq;
using Application.DDD_API.Application.Dtos;
using Application.DDD_API.Application.Interface.Mappers;
using Domain.DDD_API.Domain.Entities;

namespace Application.DDD_API.Application.Mappers
{
    public class ProductMapper : IProductMapper
    {

        public Product MapperDtoEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Price = productDto.Price
            };
            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
            };
            return productDto;
        }
        public IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products)
        {
            var dto = products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            });
            return dto;
        }
    }
}