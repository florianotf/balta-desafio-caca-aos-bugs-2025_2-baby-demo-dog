using BugStore.Data;
using BugStore.Requests.Products;
using BugStore.Responses.Products;

namespace BugStore.Handlers.Products;

public class DeleteProductHandler : IDeleteProductHandler
{
    private readonly AppDbContext _context;

    public DeleteProductHandler(AppDbContext context)
    {
        _context = context;
    }

    public DeleteProductResponse Handle(DeleteProductRequest request)
    {
        var result = _context.Products.Remove(new Models.Product
        {
            Id = request.ProductId
        });

        _context.SaveChanges();

        return new DeleteProductResponse
        {
            Id = request.ProductId,
            DeletedAt = DateTime.UtcNow
        };
    }
}
