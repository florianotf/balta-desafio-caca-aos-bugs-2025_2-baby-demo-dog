namespace BugStore.Responses.Orders;

public class GetByIdCOrderResponse
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
}