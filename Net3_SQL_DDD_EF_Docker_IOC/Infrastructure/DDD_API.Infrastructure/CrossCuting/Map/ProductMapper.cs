using System.Collections.Generic;
using System.Linq;
using Application.DDD_API.Application.Dtos;
using Domain.DDD_API.Domain.Entities;
using Infrastructure.DDD_API.Infrastructure.CrossCuting.Interfaces;

namespace Infrastructure.DDD_API.Infrastructure.CrossCuting.Map
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

        public ProductDto MaperEntityToDto(Product product)
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
             var dto = products.Select(p => new ProductDto  {   Id = p.Id,
                                                                Name = p.Name,
                                                                Price = p.Price
             });
            return dto;
        }
    }
}