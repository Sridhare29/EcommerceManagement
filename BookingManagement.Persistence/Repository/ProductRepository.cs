using Dapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
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
            var query = "INSERT INTO product ( Category_Id, Name, Description, Product_Image) " +
             "VALUES ( @Category_Id, @Name, @Description, @Product_Image);";
            using (IDbConnection connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, product).ConfigureAwait(false);
                return product;
            }

        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var query = "SELECT * FROM product WHERE Id = @Id";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var productsctg = await connection.QueryFirstOrDefaultAsync<Product>(query, new { id });
                return productsctg;
            }
        }

        public async Task<IEnumerable<Product>> GetProductAsync()
        {
            var query = "SELECT * FROM product";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var users = await connection.QueryAsync<Product>(query);
                return users.ToList();
            }
        }
    }
}
