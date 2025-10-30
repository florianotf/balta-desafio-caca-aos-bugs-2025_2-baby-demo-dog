using BugStore.Data;
using BugStore.Handlers.Customers;
using BugStore.Requests.Customers;
using BugStore.Responses.Customers;

namespace BugStore.Handlers.Orders;

public class DeleteCustomerHandler : IDeleteCustomerHandler
{
    private readonly AppDbContext _context;

    public DeleteCustomerHandler(AppDbContext context)
    {
        _context = context;
    }

    public DeleteCustomerResponse Handle(DeleteCustomerRequest request)
    {
        var result = _context.Customers.Add(new Models.Customer
        {
            Id = Guid.NewGuid()
        });

        _context.SaveChanges();

        return new DeleteCustomerResponse
        {
            Id = result.Entity.Id
        };
    }
}