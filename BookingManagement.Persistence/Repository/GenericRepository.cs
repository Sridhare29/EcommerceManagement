using Ecommerce.Management.Application.Interface;
using Ecommerce.Management.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement.Persistence.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly EcommerceApplicationContext _ecommerceApplicationContext;
        public GenericRepository(EcommerceApplicationContext ecommerceApplicationContext)
        {
            this._ecommerceApplicationContext = ecommerceApplicationContext;
        }
        public async Task CreateAsync(T entity)
        {
            await _ecommerceApplicationContext.AddAsync(entity);
            await _ecommerceApplicationContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
             _ecommerceApplicationContext.Remove(entity);
            await _ecommerceApplicationContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _ecommerceApplicationContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _ecommerceApplicationContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _ecommerceApplicationContext.Update(entity);
            _ecommerceApplicationContext.Entry(entity).State = EntityState.Modified;
            await _ecommerceApplicationContext.SaveChangesAsync();
        }


    }
}
