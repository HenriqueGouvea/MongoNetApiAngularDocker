using Store.API.Domain.Models;
using Store.API.Domain.Services.Interfaces;
using Store.API.Repository.Interfaces;

namespace Store.API.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<KeyValuePair<int, List<Product>>> GetAll(string name, int page, int limit)
        {
            var skip = page <= 1 ? 0 : (page - 1) * limit;
            return await _productRepository.GetAll(name.Trim(), limit, skip);
        }

        public async Task Create(Product product)
        {
            await _productRepository.Create(product);
        }
    }
}
