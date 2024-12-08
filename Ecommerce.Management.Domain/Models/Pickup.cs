using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Models
{
    public class Pickup
    {
        public Guid Id { get; set; }
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
