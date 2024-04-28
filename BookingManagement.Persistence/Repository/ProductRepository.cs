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
            var query = "INSERT INTO products ( Category_Id, Name, Description, Product_Image) " +
             "VALUES ( @Category_Id, @Name, @Description, @Product_Image);";
            using (IDbConnection connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, product).ConfigureAwait(false);
                return product;
            }

        }

        public Task<Product> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
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
