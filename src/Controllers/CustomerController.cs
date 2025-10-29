using BugStore.Handlers.Customers;
using BugStore.Requests.Customers;
using Microsoft.AspNetCore.Mvc;

namespace BugStore.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command
        )
        {
            var response = handler.Handle(command);
            return Created($"/v1/customers/{response.Id}", response);
        }
    }

}