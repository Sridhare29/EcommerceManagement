using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Response.Queries.Product
{
    public class GetProductByIDResponseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Product_Image { get; set; }
        public Guid Category_Id { get; set; }
        public ProductCategory Category { get; set; }

    }
}
