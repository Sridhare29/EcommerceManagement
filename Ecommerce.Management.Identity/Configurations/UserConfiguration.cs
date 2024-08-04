using Ecommerce.Management.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData
                (
                   new ApplicationUser
                   {
                       Id = "1bdc963f-5e14-411a-b49a-d74c41c6a8b0",
                       Email = "user@localhost.com",
                       NormalizedEmail = "USER@LOCALHOST.COM",
                       FirstName = "System",
                       LastName = "User",
                       UserName = "user@localhost",
                       NormalizedUserName = "USER@LOCALHOST.COM",
                       PasswordHash = hasher.HashPassword(null, "U$er@ssw0rd"),
                       EmailConfirmed = true
                   },
                  new ApplicationUser
                  {
                      Id = "d7641b2f-ac20-443b-ad51-0125422c01bd",
                      Email = "admin@localhost.com",
                      NormalizedEmail = "ADMIN@LOCALHOST.COM",
                      FirstName = "System",
                      LastName = "Admin",
                      UserName = "admin@localhost.com",
                      NormalizedUserName = "Admin@LOCALHOST.COM",
                      PasswordHash = hasher.HashPassword(null, "@dminP@ssw0rd"),
                      EmailConfirmed = true
                  }
                );
        }
    }
}
