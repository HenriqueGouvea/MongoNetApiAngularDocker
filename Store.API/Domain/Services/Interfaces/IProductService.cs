using Store.API.Domain.Models;

namespace Store.API.Domain.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<KeyValuePair<int, List<Product>>> GetAll(string name, int page, int limit);
        Task Create(Product product);
    }
}
