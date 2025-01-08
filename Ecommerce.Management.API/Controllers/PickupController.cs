using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Command.Address;
using Ecommerce.Management.Domain.Request.Command.Pickup;
using Ecommerce.Management.Domain.Request.Queries.Address;
using Ecommerce.Management.Domain.Request.Queries.Pickup;
using Ecommerce.Management.Domain.Response.Queries.Address;
using Ecommerce.Management.Domain.Response.Queries.Pickup;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("v1/pickup")]
    [ApiController]
    public class PickupController : ControllerBase
    {
        private readonly IPickupRequest _pickupRequest;
        public readonly IMediator _mediator;

        public PickupController(IPickupRequest pickupRequest, IMediator mediator)
        {
            _pickupRequest = pickupRequest;
            this._mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetPickupByIdResponseModel>> GetUserById(Guid id)
        {
            var response = await _mediator.Send(new GetPickupByIdRequestModel(id));
            return Ok(response);
        }

        [HttpPost("request")]
        public async Task<IActionResult> CreatePickupRequest([FromBody] PostPickupRequestModel postPickupRequestModel)
        {
            var response = await _mediator.Send(postPickupRequestModel);
            return CreatedAtAction(nameof(GetUserById), new { id = response }, postPickupRequestModel);

        }

    }
}
