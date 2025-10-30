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

        [HttpGet]
        [Route("")]
        public IActionResult Get(
            [FromServices] IGetCustomerHandler handler
        )
        {
            var response = handler.Handle();
            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(
            [FromServices] IGetByIdCustomerHandler handler,
            [FromRoute] GetByIdCustomerRequest command
        )
        {
            var response = handler.Handle(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(
            Guid id,
            [FromServices] IUpdateCustomerHandler handler,
            [FromBody] UpdateCustomerRequest command
        )
        {
            command.Id = id;
            var response = handler.Handle(command);
            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(
            [FromServices] IDeleteCustomerHandler handler,
            [FromRoute] DeleteCustomerRequest command
        )
        {
            handler.Handle(command);
            return NoContent();
        }
    }

}