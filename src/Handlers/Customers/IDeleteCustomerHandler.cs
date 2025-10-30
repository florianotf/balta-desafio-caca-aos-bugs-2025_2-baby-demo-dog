using BugStore.Requests.Customers;
using BugStore.Responses.Customers;

namespace BugStore.Handlers.Customers
{
    public interface IDeleteCustomerHandler
    {
        DeleteCustomerResponse Handle(DeleteCustomerRequest request);
    }
}