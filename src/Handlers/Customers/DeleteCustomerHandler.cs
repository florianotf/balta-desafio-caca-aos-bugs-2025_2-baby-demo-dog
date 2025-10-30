using BugStore.Data;
using BugStore.Requests.Customers;
using BugStore.Responses.Customers;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BugStore.Handlers.Customers;

public class DeleteCustomerHandler : IDeleteCustomerHandler
{
    private readonly AppDbContext _context;

    public DeleteCustomerHandler(AppDbContext context)
    {
        _context = context;
    }

    public DeleteCustomerResponse Handle(DeleteCustomerRequest request)
    {
        var result = _context.Customers.Remove(new Models.Customer
        {
            Id = request.Id
        });

        _context.SaveChanges();

        return new DeleteCustomerResponse
        {
            Id = request.Id,
            DeletedAt = DateTime.UtcNow,
            Message = "Customer deleted successfully"
        };
    }
}