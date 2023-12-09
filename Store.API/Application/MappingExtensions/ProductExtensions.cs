using Store.API.Application.RequestObjects;
using Store.API.Application.ResponseObjects;
using Store.API.Domain.Models;

namespace Store.API.Application.MappingExtensions
{
    public static class ProductExtensions
    {
        public static ProductResponse ToProductResponse(this Product product)
        {
            return new ProductResponse
            {
                Id = product.Id ?? string.Empty,
                IsDeleted = product.IsDeleted,
                Name = product.Name,
                PictureUrl = product.PictureUrl,
                Price = product.Price
            };
        }

        public static Product ToProductDataEntity(this ProductResponse product)
        {
            return new Product
            {
                Id = product.Id,
                IsDeleted = product.IsDeleted,
                Name = product.Name,
                PictureUrl = product.PictureUrl,
                Price = product.Price
            };
        }

        public static IEnumerable<ProductResponse> ToProductResponse(this List<Product> products)
        {
            foreach (var product in products)
            {
                yield return ToProductResponse(product);
            }
        }

        public static PaginatedProductsResponse ToPaginatedProductsResponse(this KeyValuePair<int, List<Product>> paginationResult)
        {
            var result = new List<ProductResponse>();
            paginationResult.Value.ForEach(p => result.Add(ToProductResponse(p)));

            return new PaginatedProductsResponse
            {
                Products = result,
                Total = paginationResult.Key,
                PageTotal = result.Count
            };
        }

        public static Product ToProductDataEntity(this CreateProductRequest product)
        {
            return new Product
            {
                Name = product.Name,
                PictureUrl = product.PictureUrl,
                Price = product.Price
            };
        }
    }
}
