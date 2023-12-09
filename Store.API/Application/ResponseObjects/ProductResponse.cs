namespace Store.API.Application.ResponseObjects
{
    public class ProductResponse
    {
        public required string Id { get; set; }

        public required string Name { get; set; }

        public required string PictureUrl { get; set; }

        public required decimal Price { get; set; }

        public required bool IsDeleted { get; set; }
    }
}
