using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Response.Queries.ProductCategorys
{
    public class GetProductCategoryResponseModel
    {
        public Guid Id { get; set; }
        public string Category_Name { get; set; }
    }
}
