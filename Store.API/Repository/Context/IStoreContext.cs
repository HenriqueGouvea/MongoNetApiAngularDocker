using MongoDB.Driver;
using Store.API.Domain.Models;

namespace Store.API.Repository.Context
{
    public interface IStoreContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
