namespace BugStore.Responses.Customers;

public class GetCustomerResponse
{
    public IEnumerable<Models.Customer> Customers { get; set; }

}