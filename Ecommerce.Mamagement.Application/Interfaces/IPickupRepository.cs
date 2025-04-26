using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Command.Pickup;
using Ecommerce.Management.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Interfaces
{
    public interface IPickupRepository
    {
        public Task<IEnumerable<Pickup>> GetPickupAsync();
        public Task<Pickup> GetByIdAsync(Guid id);
        public Task<Pickup> CreatePickupRequest(Pickup pickupRequest);
    }
}
