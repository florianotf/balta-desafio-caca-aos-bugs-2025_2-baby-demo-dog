using BugStore.Requests.Orders;
using BugStore.Responses.Orders;

namespace BugStore.Handlers.Orders
{
    public interface IGetByIdOrderHandler
    {
        GetByIdOrderResponse Handle(GetByIdOrderRequest request);
    }
}
