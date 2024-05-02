using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Interfaces
{
    public interface IProductCategoryRepository
    {
        public Task<IEnumerable<ProductCategory>> GetProductCategoryAsync();

        public Task<ProductCategory> GetByIdAsync(Guid id);

        public Task<ProductCategory> createProductCategoryAsync(ProductCategory productCategory);
    }
}
