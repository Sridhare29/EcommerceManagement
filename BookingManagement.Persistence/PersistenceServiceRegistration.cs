using BookingManagement.Persistence.Repository;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using EcommerceManagement.Persistence.DatabaseContext;
using EcommerceManagement.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement.Persistence
{
    public static class PersistenceServiceRegistration 
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            /*  services.AddDbContext<EcommerceApplicationContext>(options =>
              {
                  options.UseSqlServer(configuration.GetConnectionString("EcommerceConnection"));
              });*/
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductItemRepository, ProductItemRepository>();

            services.AddSingleton<EcommerceApplicationContext>();
            services.AddSingleton<MinatiAuthApplicationContext>();
            /*            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                        services.AddScoped<IUserQueryRepository, UserRepository >();
            */
            return services;
        }
    }
}
