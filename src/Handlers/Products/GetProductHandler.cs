using BugStore.Data;
using BugStore.Models;
using BugStore.Requests.Products;
using BugStore.Responses.Products;

namespace BugStore.Handlers.Products;

public class GetProductHandler : IGetProductHandler
{
    private readonly AppDbContext _context;

    public GetProductHandler(AppDbContext context)
    {
        _context = context;
    }

    public GetProductResponse Handle()
    {
        var result = _context.Products.ToList();

        return new GetProductResponse
        {
            Products = result.Select(p => new Product
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Slug = p.Slug,
                Price = p.Price
            }).ToList()
        };
    }
}
