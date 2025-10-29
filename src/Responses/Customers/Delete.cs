namespace BugStore.Responses.Customers;

public class DeleteCustomerResponse
{
    public Guid Id { get; set; }
    public DateTime DeletedAt { get; set; }
}