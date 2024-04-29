using Ecommerce.Management.Domain.Request.Command.ProductCategorys;
using Ecommerce.Management.Domain.Request.Command.ProductItem;
using Ecommerce.Management.Domain.Request.Queries.Product;
using Ecommerce.Management.Domain.Request.Queries.ProductItem;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.ProductItem;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductItemController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ProductItemController(IMediator mediator)
        {
            this._mediator = mediator;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductItemByIDResponseModel>> GetUserById(Guid id)
        {
            var response = await _mediator.Send(new GetProductItemByIdRequestModel(id));
            return Ok(response);
        }

        [HttpPost]
        [Route("ProductItemPost")]
        public async Task<ActionResult> PostProductCategory(PostProductItemRequestModel postProductItemRequestModel)
        {
            var response = await _mediator.Send(postProductItemRequestModel);
            return CreatedAtAction(nameof(GetUserById), new { id = response }, postProductItemRequestModel);
        }
    }
}
