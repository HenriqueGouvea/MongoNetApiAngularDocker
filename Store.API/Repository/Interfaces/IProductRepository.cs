using Store.API.Domain.Models;

namespace Store.API.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
        Task Create(Product product);
        Task<KeyValuePair<int, List<Product>>> GetAll(string name, int limit, int skip);
    }
}
