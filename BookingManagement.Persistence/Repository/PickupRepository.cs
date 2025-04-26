using Dapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using System.Data;
using System.Threading.Tasks;

namespace EcommerceManagement.Persistence.Repository
{
    public class PickupRepository : IPickupRepository
    {
        private readonly EcommerceApplicationContext _context;

        public PickupRepository(EcommerceApplicationContext context)
        {
            _context = context;
        }

        public async Task<Pickup> CreatePickupRequest(Pickup pickupRequest)
        {
            var query = "[dbo].[AddPickupRequest]";
            var parameters = new DynamicParameters();
            pickupRequest.Status ??= "Pending";

            // Adding parameters to match the stored procedure

            parameters.Add("@AddressId", pickupRequest.AddressId);
            parameters.Add("@ExpectedWeight", pickupRequest.ExpectedWeight);
            parameters.Add("@PickupDate", pickupRequest.PickupDate);
            parameters.Add("@Message", pickupRequest.Message);
            parameters.Add("@PickupSlot", pickupRequest.PickupSlot);
            parameters.Add("@Status", pickupRequest.Status);


            using (var connection = this._context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
            }

            return pickupRequest;
        }

        public async Task<Pickup> GetByIdAsync(Guid id)
        {
            var query = "[dbo].[GetPickupRequestById]";
            DynamicParameters dynamicParameters = new DynamicParameters();

            // Correct parameter name to match the stored procedure
            dynamicParameters.Add("@ID", id);

            using (IDbConnection connection = _context.CreateConnection())
            {
                var pickupById = await connection.QuerySingleOrDefaultAsync<Pickup>(
                    query,
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure
                );

                return pickupById;
            }
        }

        public async Task<IEnumerable<Pickup>> GetPickupAsync()
        {
            var query = "[dbo].[GetTopPickupRequests]";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<Pickup>(query, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}