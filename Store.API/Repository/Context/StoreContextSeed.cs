using MongoDB.Driver;
using Store.API.Domain.Models;

namespace Store.API.Repository.Context
{
    public class StoreContextSeed
    {
        public static void SeedData(IMongoCollection<Product> products)
        {
            var hasProducts = products.Find(p => true).Any();

            if (!hasProducts)
                products.InsertMany(GetFirstProducts());
        }

        private static IEnumerable<Product> GetFirstProducts()
        {
            return new List<Product>
            {
                new Product {
                    Id = "602d2149e773f2a3990b47f5",
                    IsDeleted = false,
                    Name = "Jacket",
                    PictureUrl = "https://cdn-images.farfetch-contents.com/22/13/20/56/22132056_52285089_480.jpg",
                    Price = 200
                },
                new Product {
                    Id = "602d2149e773f2a3990b47f6",
                    IsDeleted = false,
                    Name = "Sneaker",
                    PictureUrl = "https://cdn-images.farfetch-contents.com/16/40/35/69/16403569_31752432_480.jpg",
                    Price = 100
                },
                new Product {
                    Id = "602d2149e773f2a3990b47f7",
                    IsDeleted = false,
                    Name = "T-shirt",
                    PictureUrl = "https://cdn-images.farfetch-contents.com/17/80/55/03/17805503_37649833_480.jpg",
                    Price = 40
                },
                new Product {
                    Id = "602d2149e773f2a3990b47f8",
                    IsDeleted = false,
                    Name = "Trousers A",
                    PictureUrl = "https://cdn-images.farfetch-contents.com/21/50/32/18/21503218_51568734_480.jpg",
                    Price = 60
                },
                new Product {
                    Id = "602d2149e773f2a3990b47f9",
                    IsDeleted = false,
                    Name = "Trousers B",
                    PictureUrl = "https://cdn-images.farfetch-contents.com/22/07/16/39/22071639_52034981_480.jpg",
                    Price = 70
                },
            };
        }
    }
}
