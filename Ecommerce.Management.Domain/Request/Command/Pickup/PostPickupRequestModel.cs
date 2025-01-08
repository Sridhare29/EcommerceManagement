using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Command.Pickup
{
    public class PostPickupRequestModel : IRequest<Guid>
    {
        public string PickupSlot { get; set; }
        public string ExpectedWeight { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime PickupDate { get; set; }
        public Guid AddressId { get; set; }
    }
}
