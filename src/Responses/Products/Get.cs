namespace BugStore.Responses.Products;

public class GetProductResponse
{
    public IEnumerable<Models.Product> Products { get; set; } = null!;

}