using Ecommerce.Management.Domain.Request.Command.User;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet("users")]
        public async Task<ActionResult<List<GetUserResponseModel>>> GetUsers()
        {
            var users = await _mediator.Send(new GetUserRequestModel());
            return Ok(users);
        }

        [HttpGet("users/{id}")]
        public async Task<ActionResult<GetUserDetailResponseModel>> GetUserById(Guid id)
        {
            var user = await _mediator.Send(new GetUserDetailRequestModel(id));
            return Ok(user);
        }
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> PostUser(CreateUserCommand createUserCommand)
        {
            var users =  await _mediator.Send(createUserCommand);
            return CreatedAtAction(nameof(GetUserById), new { id = Response });
        }
        [HttpPut("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> PutUser(UpdateUserCommand updateUserCommand)
        {
            var users = await _mediator.Send(updateUserCommand);
            return NoContent();
        }
    }
}
