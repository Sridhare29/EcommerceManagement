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

        public async Task<Address> CreateAddress(Address address)
        {
            var query = "[dbo].[InsertAddressDetails]";
            var parameters = new DynamicParameters();

            // Adding parameters for the stored procedure
            parameters.Add("@unit_number", address.UnitNumber);
            parameters.Add("@street_number", address.StreetNumber);
            parameters.Add("@address_line1", address.AddressLine1);
            parameters.Add("@address_line2", address.AddressLine2);
            parameters.Add("@city", address.City);
            parameters.Add("@region", address.Region);
            parameters.Add("@postal_code", address.PostalCode);
            parameters.Add("@country", address.Country);

            using (var connection = this._context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
            }

            return address; // Returning the inserted address object
        }

    }
}
