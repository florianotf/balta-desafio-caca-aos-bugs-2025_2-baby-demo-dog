using BugStore.Requests.Products;
using BugStore.Responses.Products;

namespace BugStore.Handlers.Products
{
    public interface ICreateProductHandler
    {
        CreateProductResponse Handle(CreateProductRequest request);
    }
}
