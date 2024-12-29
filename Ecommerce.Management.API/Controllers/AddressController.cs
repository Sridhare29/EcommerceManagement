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
        public async Task<ActionResult<IEnumerable<GetAddressResponseModel>>> GetProductCategory()
        {
            var response = await _mediator.Send(new GetAddressRequestModel());
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GetAddressByIdResponseModel>> GetUserById(Guid id)
        {
            var response = await _mediator.Send(new GetAddressByIdRequestModel(id));
            return Ok(response);
        }
    }
}
