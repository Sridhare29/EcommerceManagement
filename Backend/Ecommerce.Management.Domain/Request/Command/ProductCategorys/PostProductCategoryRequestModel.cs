using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Command.ProductCategorys
{
    public class PostProductCategoryRequestModel : IRequest<Guid>
    {
        public string category_name { get; set; }

    }
}
