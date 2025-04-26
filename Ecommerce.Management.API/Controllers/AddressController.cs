using Ecommerce.Management.Domain.Request.Command.Address;
using Ecommerce.Management.Domain.Request.Command.Product;
using Ecommerce.Management.Domain.Request.Queries.Address;
using Ecommerce.Management.Domain.Request.Queries.Product;
using Ecommerce.Management.Domain.Request.Queries.ProductCategorys;
using Ecommerce.Management.Domain.Response.Queries.Address;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.ProductCategorys;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("v1/Address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        public readonly IMediator _mediator;
        public AddressController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAddressResponseModel>>> GetAddressDetails()
        {
            var response = await _mediator.Send(new GetAddressRequestModel());
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GetAddressByIdResponseModel>> GetAddressById(Guid id)
        {
            var response = await _mediator.Send(new GetAddressByIdRequestModel(id));
            return Ok(response);
        }
        [HttpPost]
        [Route("AddressPost")]
        public async Task<ActionResult> PostUser(PostAddressRequestModel postAddressRequestModel)
        {
            var response = await _mediator.Send(postAddressRequestModel);
            return CreatedAtAction(nameof(GetAddressById), new { id = response }, postAddressRequestModel);
        }
    }
}
