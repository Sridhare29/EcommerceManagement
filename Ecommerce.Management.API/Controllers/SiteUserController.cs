using BookingManagement.Persistence.Repository;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Command.User;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response.Queries.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("api/V1/user")]
    [ApiController]
    public class SiteUserController : ControllerBase
    {
        public readonly IMediator _mediator;
        public SiteUserController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetUserResponseModel>>> GetUser()
        {
            var response = await _mediator.Send(new GetUserRequestModel());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetUserByIdResponseModel>> GetUserById(Guid id)
        {
            var response = await _mediator.Send(new GetUserByIdRequestModel(id));
            return Ok(response);
        }
        [HttpPost]
        [Route("UserPost")]
        public async Task<ActionResult> PostUser(PostUserRequestModel postUserRequestModel)
        {
            var response = await _mediator.Send(postUserRequestModel);
            return CreatedAtAction(nameof(GetUserById), new { id = response }, postUserRequestModel);
        }
    }
}
