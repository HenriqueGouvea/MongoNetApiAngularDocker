using Store.API.Domain.Services.Interfaces;
using Store.API.Application.MappingExtensions;

namespace Store.API.Application.Endpoints.Products
{
    public static partial class ProductsEndpointGroup
    {
        private static async Task<IResult> GetAll(IProductService productService)
        {
            var products = await productService.GetAll();
            return Results.Ok(products.ToProductResponse());
        }
    }
}
