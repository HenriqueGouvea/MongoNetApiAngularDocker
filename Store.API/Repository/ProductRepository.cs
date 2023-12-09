using MongoDB.Driver;
using Store.API.Domain.Models;
using Store.API.Repository.Context;
using Store.API.Repository.Interfaces;

namespace Store.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IStoreContext _context;

        public ProductRepository(IStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.Find(p => !p.IsDeleted).ToListAsync();
        }

        public async Task<KeyValuePair<int, List<Product>>> GetAll(string name, int limit, int skip)
        {
            var allResults = _context.Products.AsQueryable()
                                               .Where(p => !p.IsDeleted && p.Name.ToLower().Contains(name))
                                               .ToList();

            var total = allResults.Count;
            var filtered = allResults.Skip(skip).Take(limit).ToList();
            return new KeyValuePair<int, List<Product>>(total, filtered);
        }

        public async Task Create(Product product)
        {
            await _context.Products.InsertOneAsync(product);
        }
    }
}
