using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Interfaces.Queries
{
    public interface IUserQueryRepository
    {
        Task<User?> GetByIdAsync(Guid id);

        Task<User> CreateAsync(User user);

        Task<User> UpdateAsync(Guid id, User user);

    }
}
