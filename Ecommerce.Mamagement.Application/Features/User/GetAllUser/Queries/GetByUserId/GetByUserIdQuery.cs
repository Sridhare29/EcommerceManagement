using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Features.User.GetAllUser.Queries.GetByUserId
{
    public record GetByUserIdQuery(Guid Id) : IRequest<UserDetailsDto>;

}
