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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "8b3e7a9d-c3a3-4695-b2b8-8567b8671b74",
                    UserId = "d7641b2f-ac20-443b-ad51-0125422c01bd"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "598ccd75-f89e-4104-ab0e-f68f3856e575",
                    UserId = "1bdc963f-5e14-411a-b49a-d74c41c6a8b0"
                }
            );
        }
    }
}
