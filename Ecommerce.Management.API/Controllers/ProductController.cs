using Ecommerce.Management.Domain.Request.Command.Product;
using Ecommerce.Management.Domain.Request.Command.User;
using Ecommerce.Management.Domain.Request.Queries;
using Ecommerce.Management.Domain.Request.Queries.Product;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetProductResponseModel>>> GetUser()
        {
            var response = await _mediator.Send(new GetProductRequestModel());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductByIDResponseModel>> GetUserById(Guid id)
        {
            var response = await _mediator.Send(new GetProductByIdRequestModel(id));
            return Ok(response);
        }

        [HttpPost]
        [Route("ProductPost")]
        public async Task<ActionResult> PostUser(PostProductRequestModel postProductRequest)
        {
            var response = await _mediator.Send(postProductRequest);
            return CreatedAtAction(nameof(GetUserById), new { id = response }, postProductRequest);
        }
    }
}
