using Ecommerce.Management.Domain.Request.Command.ProductCategorys;
using Ecommerce.Management.Domain.Request.Command.ProductItem;
using Ecommerce.Management.Domain.Request.Queries;
using Ecommerce.Management.Domain.Request.Queries.Product;
using Ecommerce.Management.Domain.Request.Queries.ProductItem;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.ProductItem;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ProductItemController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ProductItemController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetProductItemResponseModel>>> GetProductItem()
        {
            var response = await _mediator.Send(new GetProductItemRequestModel());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductItemByIDResponseModel>> GetProductItemById(Guid id)
        {
            var response = await _mediator.Send(new GetProductItemByIdRequestModel(id));
            return Ok(response);
        }

        [HttpPost]
        [Route("ProductItemPost")]
        public async Task<ActionResult> PostProductItem(PostProductItemRequestModel postProductItemRequestModel)
        {
            var response = await _mediator.Send(postProductItemRequestModel);
            return CreatedAtAction(nameof(GetProductItemById), new { id = response }, postProductItemRequestModel);
        }
    }
}
