using System.ComponentModel.Design;
using System.Collections.Generic;
using Application.DDD_API.Application.Dtos;
using Application.DDD_API.Application.Interface;
using Application.DDD_API.Application.Interface.Mappers;
using DDD_API.Domain.Core.Interfaces.Services;

namespace Application.DDD_API.Application
{
    public class ProductServiceApplication : IProductServiceApplication
    {
        private readonly IProductService productService;
        private readonly IProductMapper productMapper;
        public ProductServiceApplication(IProductService productService,
                                        IProductMapper productMapper)
        {
            this.productService = productService;
            this.productMapper = productMapper;
        }

        public void Add(ProductDto productDto)
        {
            var product = productMapper.MapperDtoEntity(productDto);
            productService.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = productService.GetAll();
            return productMapper.MapperListProductDto(products);

        }

        public ProductDto GetById(int id)
        {
            var product = productService.GetById(id);
            return productMapper.MapperEntityToDto(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = productMapper.MapperDtoEntity(productDto);
            productService.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = productMapper.MapperDtoEntity(productDto);
            productService.Update(product);
        }
    }
}