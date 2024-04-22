using Ecommerce.Management.Application.Interface;
using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Interfaces.Queries
{
    public interface IUserQueryRepository : IGenericRepository<User>
    {
        Task<bool> IsUsernameUniqueAsync(string username);
        Task<bool> IsEmailUniqueAsync(string email);
    }
}
