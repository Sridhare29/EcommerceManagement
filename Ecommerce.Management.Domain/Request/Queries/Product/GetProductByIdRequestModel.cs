using Ecommerce.Management.Domain.Response.Queries.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.Product
{
    public class GetProductByIdRequestModel : IRequest<GetProductByIDResponseModel>
    {   
        public GetProductByIdRequestModel(Guid id)
        {
            this.Id = id;
        }
        public Guid Id { get; set; }

    }
}
