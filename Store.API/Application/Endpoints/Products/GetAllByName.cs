using Store.API.Domain.Services.Interfaces;
using Store.API.Application.MappingExtensions;

namespace Store.API.Application.Endpoints.Products
{
    public static partial class ProductsEndpointGroup
    {
        private static async Task<IResult> GetAllByName(IProductService productService, string name, int page, int limit)
        {
            var products = await productService.GetAll(name, page, limit);
            return Results.Ok(products.ToPaginatedProductsResponse());
        }
    }
}
