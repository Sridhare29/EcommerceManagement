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
    public class UserRepository : IUserQueryRepository
    {
        protected readonly EcommerceApplicationContext _ecommerceApplicationContext;
        public UserRepository(EcommerceApplicationContext ecommerceApplicationContext)
        {
            this._ecommerceApplicationContext = ecommerceApplicationContext;
        }
        public async Task<User> CreateAsync(User user)
        {
            await _ecommerceApplicationContext.AddAsync(user);
            await _ecommerceApplicationContext.SaveChangesAsync();
            return user;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            return await _ecommerceApplicationContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> UpdateAsync(Guid id, User user)
        {
            var userToUpdate = await _ecommerceApplicationContext.Users.FirstOrDefaultAsync(x => x.Id == id);   
            if (userToUpdate != null)
            {
                return null;
            }
            _ecommerceApplicationContext.Update(user);
            _ecommerceApplicationContext.Entry(user).State = EntityState.Modified;
            await _ecommerceApplicationContext.SaveChangesAsync();
            return user;
        }
    }
}
