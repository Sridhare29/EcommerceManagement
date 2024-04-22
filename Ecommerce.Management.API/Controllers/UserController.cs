using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Command.User;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Management.API.Controllers
{
    [Route("api/[controller]")]
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
            var response = await _mediator.Send(new GetUserRequestModel());
            return Ok(response);
        }

        [HttpGet("users/{id}")]
        public async Task<ActionResult<GetUserDetailResponseModel>> GetUserById(Guid id)
        {
            var response = await _mediator.Send(new GetUserDetailRequestModel(id));
            return Ok(response);
        }
        [HttpPost]
        [Route("UserPost")]      
        public async Task<ActionResult> PostUser(CreateUserCommand createUserCommand)
        {
            var response =  await _mediator.Send(createUserCommand);
            return CreatedAtAction(nameof(GetUserById), new { id = response }, createUserCommand);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutUser(UpdateUserCommand updateUserCommand)
        {
            var response = await _mediator.Send(updateUserCommand);
            return Ok(response);
        }
    }
}
