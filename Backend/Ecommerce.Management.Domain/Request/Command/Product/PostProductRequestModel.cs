using Ecommerce.Management.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Command.Product
{
    public class PostProductRequestModel : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Product_Image { get; set; }
        public Guid Category_Id { get; set; }

    }
}
