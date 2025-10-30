using BugStore.Requests.Customers;
using BugStore.Responses.Customers;

namespace BugStore.Handlers.Customers
{
    public interface IUpdateCustomerHandler
    {
        UpdateCustomerResponse Handle(UpdateCustomerRequest request);
    }
}