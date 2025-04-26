using Ecommerce.Management.Domain.Response.Queries.Address;
using Ecommerce.Management.Domain.Response.Queries.Pickup;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.Pickup
{
    public class GetPickupRequestModel : IRequest<IEnumerable<GetPickupResponseModel>>;

}
