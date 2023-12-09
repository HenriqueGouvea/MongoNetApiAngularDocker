namespace Store.API.Application.RequestObjects
{
    public class GetProductRequest
    {
        public string? Id { get; set; }

        public required string Name { get; set; }

        public required string PictureUrl { get; set; }

        public required decimal Price { get; set; }
    }
}
