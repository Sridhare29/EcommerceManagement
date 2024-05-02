using Ecommerce.Management.Domain.Response.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.User
{
    public class GetUserByIdRequestModel : IRequest<GetUserByIdResponseModel>
    {
        public GetUserByIdRequestModel(Guid id)
        {
            this.Id = id;
        }
        public Guid Id { get; set; }
       
    }
}
