using Dapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using EcommerceManagement.Persistence.DatabaseContext;
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
            var query = "[dbo].[InsertProductCategory]";
            var parameter = new DynamicParameters();
            parameter.Add("@CategoryName", productCategory.category_name);
            using (var connection = this._context.CreateConnection())
            {
                var output = await connection.ExecuteAsync(query, parameter, commandType: CommandType.StoredProcedure);
            }
            return productCategory;
        }

        public async Task<ProductCategory> GetByIdAsync(Guid id)
        {
            var query = "[dbo].[GetProductCategoryById]";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("CategoryId", id);
            using (IDbConnection connection = _context.CreateConnection())
            {
                var productsctg = await connection.QuerySingleOrDefaultAsync<ProductCategory>(query, dynamicParameters, commandType: CommandType.StoredProcedure);
                return productsctg;
            }
        }

        public async Task<IEnumerable<ProductCategory>> GetProductCategoryAsync()
        {
            var query = "[dbo].[GetAllProductCategories]";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ProductCategory>(query, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}
