using Ecommerce.Management.Identity.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Identity.DBContext
{
    public class EcommerceIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public EcommerceIdentityDbContext(DbContextOptions<EcommerceIdentityDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(EcommerceIdentityDbContext).Assembly);
        }
    }
}
