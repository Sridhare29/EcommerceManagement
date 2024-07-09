using Dapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using EcommerceManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement.Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        public readonly EcommerceApplicationContext _context;
        public ProductRepository(EcommerceApplicationContext context)
        {
            this._context = context;
        }
        public async Task<Product> createProductAsync(Product product)
        {
            var query = "[dbo].[AddProduct]";
            var parameter = new DynamicParameters();
            parameter.Add("@Name", product.Name);
            parameter.Add("@Description", product.Description);
            parameter.Add("@ProductImage", product.Product_Image);
            parameter.Add("@CategoryId", product.Category_Id);
            using (var connection = this._context.CreateConnection())
            {
                var output = await connection.ExecuteAsync(query, parameter, commandType: CommandType.StoredProcedure);
            }
            return product;
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var query = "[dbo].[GetProductById]";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("ProductId", id);
            using (IDbConnection connection = _context.CreateConnection())
            {
                var productsctg = await connection.QuerySingleOrDefaultAsync<Product>(query, dynamicParameters, commandType: CommandType.StoredProcedure);
                return productsctg;
            }
        }

        public async Task<IEnumerable<Product>> GetProductAsync()
        {
            var query = "[dbo].[GetAllProduct]";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<Product>(query, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}
