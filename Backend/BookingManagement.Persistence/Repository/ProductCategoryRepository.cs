using Dapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement.Persistence.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        public readonly EcommerceApplicationContext _context;
        public ProductCategoryRepository(EcommerceApplicationContext context)
        {
            this._context = context;
        }
        public async Task<ProductCategory> createProductCategoryAsync(ProductCategory productCategory)
        {
            var query = "INSERT INTO product_category ( category_name) " +
             "VALUES ( @category_name);";
            using (IDbConnection connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, productCategory).ConfigureAwait(false);
                return productCategory;
            }
        }

        public async Task<ProductCategory> GetByIdAsync(Guid id)
        {
            var query = "SELECT * FROM product_category WHERE Id = @Id";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var productsctg = await connection.QueryFirstOrDefaultAsync<ProductCategory>(query, new { id });
                return productsctg;
            }
        }

        public async Task<IEnumerable<ProductCategory>> GetProductCategoryAsync()
        {
            var query = "SELECT * FROM product_category ";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var productsctg = await connection.QueryAsync<ProductCategory>(query);
                return productsctg.ToList();
            }
        }
    }
}
