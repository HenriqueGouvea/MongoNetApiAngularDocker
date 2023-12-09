namespace Store.API.Application.ResponseObjects
{
    public class PaginatedProductsResponse
    {
        public IList<ProductResponse> Products { get; set; } = new List<ProductResponse>();

        public int PageTotal { get; set; }

        public int Total { get; set; }
    }
}
