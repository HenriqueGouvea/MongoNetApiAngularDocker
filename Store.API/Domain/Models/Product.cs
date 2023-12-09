using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Store.API.Domain.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public required string Name { get; set; }

        public required string PictureUrl { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }
    }
}
