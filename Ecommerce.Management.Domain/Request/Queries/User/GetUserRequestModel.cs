using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Response.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.User
{
    public record class GetUserRequestModel : IRequest<IEnumerable<GetUserResponseModel>>;
   
}
