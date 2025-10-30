using BugStore.Requests.Customers;
using BugStore.Responses.Customers;

namespace BugStore.Handlers.Customers
{
    public interface IGetByIdCustomerHandler
    {
        GetByIdCustomerResponse Handle(GetByIdCustomerRequest request);
    }
}