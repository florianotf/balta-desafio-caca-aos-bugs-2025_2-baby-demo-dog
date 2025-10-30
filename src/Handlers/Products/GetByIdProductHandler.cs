using BugStore.Data;
using BugStore.Requests.Products;
using BugStore.Responses.Products;

namespace BugStore.Handlers.Products;

public class GetByIdProductHandler : IGetByIdProductHandler
{
    private readonly AppDbContext _context;

    public GetByIdProductHandler(AppDbContext context)
    {
        _context = context;
    }

    public GetByIdProductResponse Handle(GetByIdProductRequest request)
    {
        var result = _context.Products.Find(request.ProductId);

        return new GetByIdProductResponse
        {
            Id = result.Id,
            Title = result.Title,
            Description = result.Description,
            Slug = result.Slug,
            Price = result.Price
        };
    }
}
