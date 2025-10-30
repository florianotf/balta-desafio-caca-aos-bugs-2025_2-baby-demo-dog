using BugStore.Data;
using BugStore.Requests.Products;
using BugStore.Responses.Products;

namespace BugStore.Handlers.Products;

public class UpdateProductHandler : IUpdateProductHandler
{
    private readonly AppDbContext _context;

    public UpdateProductHandler(AppDbContext context)
    {
        _context = context;
    }

    public UpdateProductResponse Handle(UpdateProductRequest request)
    {
        var product = _context.Products.Find(request.ProductId);
        if (product == null)
        {
            throw new KeyNotFoundException($"Product with Id {request.ProductId} not found.");
        }

        product.Title = request.Title;
        product.Description = request.Description;
        product.Slug = request.Slug;
        product.Price = request.Price;
        var result = _context.Products.Update(product);
        _context.SaveChanges();

        return new UpdateProductResponse
        {
            Id = result.Entity.Id,
            Title = result.Entity.Title,
            Description = result.Entity.Description,
            Slug = result.Entity.Slug,
            Price = result.Entity.Price
        };
    }
}
