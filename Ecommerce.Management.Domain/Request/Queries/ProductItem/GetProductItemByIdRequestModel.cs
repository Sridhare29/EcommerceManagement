using Ecommerce.Management.Domain.Response.Queries.ProductItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.ProductItem
{
    public class GetProductItemByIdRequestModel : IRequest<GetProductItemByIDResponseModel>
    {
        public GetProductItemByIdRequestModel(Guid Id)
        {
            this.Id = Id;
        }
        public Guid Id { get; set; }
    }
}
