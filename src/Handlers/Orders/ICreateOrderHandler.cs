using BugStore.Requests.Orders;
using BugStore.Responses.Orders;

namespace BugStore.Handlers.Orders
{
    public interface ICreateOrderHandler
    {
        CreateOrderResponse Handle(CreateOrderRequest request);
    }
}
