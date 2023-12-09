namespace Store.API.Application.Endpoints.Products
{
    public static partial class ProductsEndpointGroup
    {
        public static RouteGroupBuilder MapProductEndpoints(this RouteGroupBuilder group)
        {
            group.MapGet("/", GetAll).WithSummary("Get all products");
            group.MapGet("/{name}/{page}/{total}", GetAllByName).WithSummary("Get a list of paginated products based on the parameters");
            group.MapPost("/", Create).WithSummary("Creates a new product");
            return group;
        }
    }
}
