using Ecommerce.Management.Domain.Request.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Handler.Queries.User.Queries.GetAllUser
{
    //public class GetAllUserQuery : IRequest<List<UserDto>>
    //{
    //}
    public record GetAllUserQuery : IRequest<List<UserDto>>;
}
