using Dapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using System.Data;
using System.Threading.Tasks;

namespace EcommerceManagement.Persistence.Repository
{
    public class PickupRepository : IPickupRequest
    {
        private readonly EcommerceApplicationContext _context;

        public PickupRepository(EcommerceApplicationContext context)
        {
            _context = context;
        }

        public async Task<Pickup> CreatePickupRequest(Pickup pickupRequest)
        {
            if (pickupRequest == null)
            {
                return null;
            }

            var query = "[dbo].[AddPickupRequest]";
            var parameters = new DynamicParameters();

            parameters.Add("@AddressId", pickupRequest?.AddressId);
            parameters.Add("@ExpectedWeight", pickupRequest?.ExpectedWeight);
            parameters.Add("@PickupSlot", pickupRequest?.PickupSlot);
            parameters.Add("@PickupDate", pickupRequest?.PickupDate);
            parameters.Add("@Message", pickupRequest?.Message);
            parameters.Add("@Status", pickupRequest?.Status);
            parameters.Add("@UpdatedAt", DateTime.UtcNow); // Ensure this matches the stored procedure
            parameters.Add("@CreatedAt", DateTime.UtcNow);


            using (var connection = this._context.CreateConnection())
            {
                var response = await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
            }

            return pickupRequest;
        }

    }
}