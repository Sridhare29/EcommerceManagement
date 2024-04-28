using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Interfaces
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetProductAsync();

        public Task<Product> GetByIdAsync(Guid id);

        public Task<Product> createProductAsync(Product product);

    }
}
