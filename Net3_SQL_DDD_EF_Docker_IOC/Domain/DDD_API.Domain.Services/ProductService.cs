using DDD_API.Domain.Core.Interfaces.Repositories;
using DDD_API.Domain.Core.Interfaces.Services;
using Domain.DDD_API.Domain.Entities;

namespace DDD_API.Domain.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            this.productRepository = productRepository;
        }

    }
}