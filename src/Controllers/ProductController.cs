using BugStore.Handlers.Products;
using BugStore.Requests.Products;
using Microsoft.AspNetCore.Mvc;

namespace BugStore.Controllers
{
    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Create(
            [FromServices] ICreateProductHandler handler,
            [FromBody] CreateProductRequest command
        )
        {
            var response = handler.Handle(command);
            return Created($"/v1/products/{response.Id}", response);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get(
            [FromServices] IGetProductHandler handler
        )
        {
            var response = handler.Handle();
            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(
            Guid id,
            [FromServices] IGetByIdProductHandler handler
        )
        {
            var command = new GetByIdProductRequest { ProductId = id };
            var response = handler.Handle(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(
            Guid id,
            [FromServices] IUpdateProductHandler handler,
            [FromBody] UpdateProductRequest command
        )
        {
            command.ProductId = id;
            var response = handler.Handle(command);
            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(
            Guid id,
            [FromServices] IDeleteProductHandler handler
        )
        {
            var command = new DeleteProductRequest { ProductId = id };
            handler.Handle(command);
            return NoContent();
        }
    }

}
