using BugStore.Handlers.Orders;
using BugStore.Requests.Orders;
using Microsoft.AspNetCore.Mvc;

namespace BugStore.Controllers
{
    [ApiController]
    [Route("v1/orders")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Create(
            [FromServices] ICreateOrderHandler handler,
            [FromBody] CreateOrderRequest command
        )
        {
            var response = handler.Handle(command);
            return Created($"/v1/orders/{response.Id}", response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(
            Guid id,
            [FromServices] IGetByIdOrderHandler handler
        )
        {
            var command = new GetByIdOrderRequest { OrderId = id };
            var response = handler.Handle(command);
            return Ok(response);
        }
    }

}
