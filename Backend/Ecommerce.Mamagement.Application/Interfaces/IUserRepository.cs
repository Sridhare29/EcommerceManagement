using Ecommerce.Management.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<SiteUser>> GetUsersAsync();

        public Task<SiteUser> GetByIdAsync(Guid id);

        public Task<SiteUser> createUserAsync(SiteUser user);

        public Task updateUserAsync(SiteUser user);

        public Task deleteUserAsync(Guid id);
    }
}
