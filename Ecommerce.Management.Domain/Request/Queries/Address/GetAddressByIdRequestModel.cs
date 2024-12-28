using Ecommerce.Management.Domain.Response.Queries.Address;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.Address
{
    public class GetAddressByIdRequestModel : IRequest<GetAddressByIdResponseModel>
    {
        public GetAddressByIdRequestModel(Guid id)
        {
            this.Id = id;
        }
        public Guid Id { get; set; }
    }
}
