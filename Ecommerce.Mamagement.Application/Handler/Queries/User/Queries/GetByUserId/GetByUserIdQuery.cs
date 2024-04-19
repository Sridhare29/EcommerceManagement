using Ecommerce.Management.Domain.Request.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Handler.Queries.User.Queries.GetByUserId
{
    public record GetByUserIdQuery(Guid Id) : IRequest<UserDetailsDto>;

}
