using Store.API.Application.Endpoints.Products;

namespace Store.API.Application.Endpoints
{
    public static class EndpointGroupExtensions
    {
        public static void AddEndpointGroups(this WebApplication app)
        {
            app.MapGroup("/api/store")
               .MapProductEndpoints()
               .WithTags("Store")
               .WithOpenApi();
        }
    }
}
