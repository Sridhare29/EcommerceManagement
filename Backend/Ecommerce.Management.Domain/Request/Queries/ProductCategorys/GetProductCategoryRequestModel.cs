using Ecommerce.Management.Domain.Response.Queries.ProductCategorys;
using Ecommerce.Management.Domain.Response.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Queries.ProductCategorys
{
    public class GetproductCategoryRequestModel : IRequest<IEnumerable<GetProductCategoryResponseModel>>;
    
}
