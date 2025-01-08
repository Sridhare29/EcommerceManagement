using Ecommerce.Management.Domain.Response.Queries.Pickup;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.Pickup
{
    public class GetPickupByIdRequestModel : IRequest<GetPickupByIdResponseModel>
    {
        public GetPickupByIdRequestModel(Guid Id)
        {
            this.Id = Id;
        }
        public Guid Id { get; set; }
    }
}
