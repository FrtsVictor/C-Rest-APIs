using System.Collections.Generic;
using Application.DDD_API.Application.Dtos;

namespace Application.DDD_API.Application.Interface
{
    public interface IProductServiceApplication
    {
         void Add(ProductDto productDto);
        void Update(ProductDto productDto);
        void Remove(ProductDto productDto);
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(int id);
    }
}