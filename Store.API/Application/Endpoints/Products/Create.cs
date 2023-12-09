using Microsoft.AspNetCore.Mvc;
using Store.API.Application.MappingExtensions;
using Store.API.Application.RequestObjects;
using Store.API.Domain.Services.Interfaces;

namespace Store.API.Application.Endpoints.Products
{
    public static partial class ProductsEndpointGroup
    {
        private static async Task<IResult> Create(IProductService productService, [FromBody]CreateProductRequest product)
        {
            await productService.Create(product.ToProductDataEntity());
            return Results.Ok();
        }
    }
}
