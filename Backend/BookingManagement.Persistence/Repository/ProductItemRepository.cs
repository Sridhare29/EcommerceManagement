using Dapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceManagement.Persistence.Repository
{
    public class ProductItemRepository : IProductItemRepository 
    {
        public readonly EcommerceApplicationContext _context;
        public ProductItemRepository(EcommerceApplicationContext context)
        {
            this._context = context;
        }
        

        public async Task<ProductItem> GetByIdAsync(Guid id)
        {
            var query = "[dbo].[GetProductItemDetailsByID]";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("productID", id);
            using (IDbConnection connection = _context.CreateConnection())
            {
                var productsItem = await connection.QuerySingleOrDefaultAsync<ProductItem>(query, dynamicParameters, commandType: CommandType.StoredProcedure);
                return productsItem;
            }
        }

        public async Task<IEnumerable<ProductItem>> GetProductItemAsync()
        {
            var query = "[dbo].[GetProductItemDetails]";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ProductItem>(query, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<ProductItem> createProductItemAsync(ProductItem productItem)
        {
            var query = "[dbo].[InsertProductItemDetails]";
            var parameter = new DynamicParameters();
            parameter.Add("@product_id", productItem.Product_Id);
            parameter.Add("@price", productItem.Price);
            parameter.Add("@qty_in_stock", productItem.Qty_In_Stock);
            using (var connection = this._context.CreateConnection())
            {
                var output = await connection.ExecuteAsync(query, parameter, commandType: CommandType.StoredProcedure);
            }
            return productItem;
        }
    }
}
