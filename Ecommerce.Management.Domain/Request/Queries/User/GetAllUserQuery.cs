using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.User
{
    public record GetAllUserQuery(): IRequest<List<UserDto>>;
}
