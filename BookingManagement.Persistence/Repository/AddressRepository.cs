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
    public class AddressRepository : IAddressRepository
    {
        public readonly EcommerceApplicationContext _context;

        public AddressRepository(EcommerceApplicationContext context)
        {
            this._context = context;
        }
        public Task<Address> createAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Address>> GetAddressCategoryAsync()
        {
            var query = "[dbo].[GetAllAddress]";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<Address>(query, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<Address> GetByIdAsync(Guid id)
        {
            var query = "[dbo].[GetAddressDetailsByID]";
            DynamicParameters dynamicParameters = new DynamicParameters();

            // Correct parameter name to match the stored procedure
            dynamicParameters.Add("@addressID", id);

            using (IDbConnection connection = _context.CreateConnection())
            {
                var userAddress = await connection.QuerySingleOrDefaultAsync<Address>(
                    query,
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure
                );

                return userAddress;
            }
        }
    }
}
