using Ecommerce.Management.Application.Interface;
using Ecommerce.Management.Application.Interfaces.Queries;
using Ecommerce.Management.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement.Persistence.Repository
{
    public class UserRepository : GenericRepository<User>, IUserQueryRepository
    {
        public UserRepository(EcommerceApplicationContext ecommerceApplicationContext) : base(ecommerceApplicationContext)
        {
        }

        public async Task<bool> IsEmailUniqueAsync(string email)
        {
            return await _ecommerceApplicationContext.Users.AnyAsync(q => q.Email == email) == false;
        }

        public async Task<bool> IsUsernameUniqueAsync(string username)
        {
            return await _ecommerceApplicationContext.Users.AnyAsync(q => q.Username == username) == false;
        }


    }
}
