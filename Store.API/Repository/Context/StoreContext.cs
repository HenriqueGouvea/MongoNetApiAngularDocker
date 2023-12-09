using MongoDB.Bson;
using MongoDB.Driver;
using Store.API.Domain.Models;
using System.Linq.Expressions;
using System.Collections;

namespace Store.API.Repository.Context
{
    public class StoreContext : IStoreContext
    {
        public IMongoCollection<Product> Products { get; }

        public StoreContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetValue<string>("StoreDatabaseSettings:ConnectionString");
            var client = new MongoClient(connectionString);

            var databaseName = configuration.GetValue<string>("StoreDatabaseSettings:DatabaseName");
            var database = client.GetDatabase(databaseName);

            Products = database.GetCollection<Product>(configuration.GetValue<string>("StoreDatabaseSettings:CollectionName"));

            EnsureUniqueIndex("Name", Products, Builders<Product>.IndexKeys.Ascending(a => a.Name));

            StoreContextSeed.SeedData(Products);
        }

        private void EnsureUniqueIndex<T>(string indexName, IMongoCollection<T> collection, IndexKeysDefinition<T> indexKey)
        {
            if (!IndexExists(Products, indexName))
            {
                var indexModel = new CreateIndexModel<T>(indexKey, new CreateIndexOptions { Unique = true });
                collection.Indexes.CreateOne(indexModel);
            }
        }

        public bool IndexExists<T>(IMongoCollection<T> collection, string name)
        {
            var indexes = collection.Indexes.List().ToList();
            var indexNames = indexes
                .SelectMany(index => index.Elements)
                .Where(element => element.Name == "name")
                .Select(name => name.Value.ToString());

            return indexNames.Any(i => i != null && i.Contains(name));
        }
    }
}
