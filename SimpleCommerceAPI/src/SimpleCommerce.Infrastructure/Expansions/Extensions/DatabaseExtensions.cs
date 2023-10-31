using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TransportGlobal.Infrastructure.Context;

namespace SimpleCommerce.Infrastructure.Expansions.Extensions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection RegisterDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("SimpleCommerceDB")!;

            services.AddDbContext<SimpleCommerceDBContext>(opt =>
            {
                opt.UseSqlServer(connectionString, asm =>
                {
                    asm.MigrationsAssembly(Assembly.GetAssembly(typeof(SimpleCommerceDBContext))?.GetName().Name);
                });
            });

            return services;
        }
    }
}
