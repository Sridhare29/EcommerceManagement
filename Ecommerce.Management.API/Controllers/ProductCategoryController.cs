using Ecommerce.Management.Domain.Request.Command.Product;
using Ecommerce.Management.Domain.Request.Command.ProductCategorys;
using Ecommerce.Management.Domain.Request.Queries;
using Ecommerce.Management.Domain.Request.Queries.Product;
using Ecommerce.Management.Domain.Request.Queries.ProductCategorys;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.ProductCategorys;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("v1/ProductCategory")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ProductCategoryController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetProductCategoryResponseModel>>> GetProductCategory()
        {
            var response = await _mediator.Send(new GetproductCategoryRequestModel());
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductCategoryByIdResponseModel>> GetUserById(Guid id)
        {
            var response = await _mediator.Send(new GetproductCategoryByIdRequestModel(id));
            return Ok(response);
        }

        [HttpPost]
        [Route("ProductCategoryPost")]
        public async Task<ActionResult> PostProductCategory(PostProductCategoryRequestModel postProductCategoryRequestModel)
        {
            var response = await _mediator.Send(postProductCategoryRequestModel);
            return CreatedAtAction(nameof(GetUserById), new { id = response }, postProductCategoryRequestModel);
        }
    }
}
