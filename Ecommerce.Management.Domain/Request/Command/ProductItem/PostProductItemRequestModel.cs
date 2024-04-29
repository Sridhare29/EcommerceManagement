using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Command.ProductItem
{
    public class PostProductItemRequestModel : IRequest<Guid>
    {
        public Guid Product_Id { get; set; }
        public int Qty_In_Stock { get; set; }
        public int Price { get; set; }
    }
}
