using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Command.Pickup;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPost]
        public async Task<IActionResult> CreatePickupRequest([FromBody] PickupRequest pickupRequest)
        {
            if (pickupRequest == null)
            {
                return BadRequest("Invalid pickup request data.");
            }
            // Call the handler through MediatR to process the request and get a response
            var response = await _mediator.Send(pickupRequest);

            // Return a successful response with the pickup request details
            return Ok(response);
        }

    }
}
