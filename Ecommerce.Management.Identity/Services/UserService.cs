using Ecommerce.Management.Application.Contracts.Identity;
using Ecommerce.Management.Domain.Models.Identity;
using Ecommerce.Management.Identity.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserService(UserManager<ApplicationUser> userManager) 
        { 
            _userManager = userManager;
        }

        public async Task<UserInfo> GetUserById(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            return new UserInfo
            {
                Email = user.Email,
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }

        public async Task<List<UserInfo>> GetUsers()
        {
            var user = await _userManager.GetUsersInRoleAsync("User");

            return user.Select(q => new UserInfo
            {
                Email = q.Email,
                Id = q.Id,
                FirstName = q.FirstName,
                LastName = q.LastName
            }).ToList();
           
        }
    }
}
