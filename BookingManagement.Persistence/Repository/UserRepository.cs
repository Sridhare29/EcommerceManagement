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
        protected readonly EcommerceApplicationContext _ecommerceApplicationContext;
        public UserRepository(EcommerceApplicationContext ecommerceApplicationContext) : base(ecommerceApplicationContext)
        {
            this._ecommerceApplicationContext = ecommerceApplicationContext;
        }

        public async Task<bool> IsUserUnique(string username)
        {
           return await _ecommerceApplicationContext.Users.AnyAsync(q => q.Username == username) == false;
        }
    }
}
