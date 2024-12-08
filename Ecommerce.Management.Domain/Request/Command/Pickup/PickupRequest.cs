using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Command.Pickup
{
    public class PickupRequest : IRequest<Guid>
    {
        public string? PickupSlot { get; set; }
        public string? ExpectedWeight { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime? PickupDate { get; set; }
        public Guid AddressId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
