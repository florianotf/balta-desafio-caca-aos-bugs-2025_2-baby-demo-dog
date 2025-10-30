using BugStore.Requests.Products;
using BugStore.Responses.Products;

namespace BugStore.Handlers.Products
{
    public interface IDeleteProductHandler
    {
        DeleteProductResponse Handle(DeleteProductRequest request);
    }
}
