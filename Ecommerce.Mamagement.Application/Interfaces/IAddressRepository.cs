using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Interfaces
{
    public interface IAddressRepository
    {
        public Task<IEnumerable<Address>> GetAddressCategoryAsync();
        public Task<Address> GetByIdAsync(Guid id);
        public Task<Address> CreateAddress(Address address);
    }
}
