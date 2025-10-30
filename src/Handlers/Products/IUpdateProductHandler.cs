using BugStore.Requests.Products;
using BugStore.Responses.Products;

namespace BugStore.Handlers.Products
{
    public interface IUpdateProductHandler
    {
        UpdateProductResponse Handle(UpdateProductRequest request);
    }
}
