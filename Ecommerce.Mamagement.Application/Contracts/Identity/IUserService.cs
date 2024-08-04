using Ecommerce.Management.Domain.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Contracts.Identity
{
    public interface IUserService
    {
        Task<List<UserInfo>> GetUsers();
        
        Task<UserInfo> GetUserById(string userId);
    }
}
