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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BookingManagement.Persistence.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly EcommerceApplicationContext _context;
        public UserRepository(EcommerceApplicationContext context)
        {
        this._context = context;
        }

        public async Task<IEnumerable<SiteUser>> GetUsersAsync()
        {
            var query = "SELECT * FROM site_user";
            using (IDbConnection connection = _context.CreateConnection())
            {
                  var users = await connection.QueryAsync<SiteUser>(query);
                  return users.ToList(); 
            }
        }

        public async Task<SiteUser> GetByIdAsync(Guid id)
        {
            var query = "SELECT * FROM site_user WHERE Id = @Id";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var users = await connection.QueryFirstOrDefaultAsync<SiteUser>(query, new {id});
                return users;
            }
        }


        public async Task<SiteUser> createUserAsync(SiteUser user)
        {
            var query = "INSERT INTO site_user (Email_Address, Phone_Number, Password) VALUES (@Email_Address, @Phone_Number, @Password);";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var id = await connection.ExecuteScalarAsync<Guid>(query, user).ConfigureAwait(false);
                user.Id = id;
                return user;
            }
        }

        public async Task deleteUserAsync(Guid id)
        {
            var query = "DELETE FROM site_user WHERE ID = @Id";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var users = await connection.ExecuteAsync(query, new { id });
            }
        }

        public async Task updateUserAsync(Guid id, SiteUser user)
        {
            var query = "UPDATE site_user SET EmailAddress = @EmailAddress," + " PhoneNumber = @PhoneNumber , Password = @Password ";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var users = await connection.ExecuteAsync(query, user);
            }
        }

       
    }
}
