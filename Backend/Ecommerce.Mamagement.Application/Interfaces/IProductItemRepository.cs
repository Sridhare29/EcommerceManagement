using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Interfaces
{
    public interface IProductItemRepository
    {
        public Task<IEnumerable<ProductItem>> GetProductItemAsync();

        public Task<ProductItem> GetByIdAsync(Guid id);

        public Task<ProductItem> createProductItemAsync(ProductItem productItem);
    }
}
