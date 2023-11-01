using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using SimpleCommerce.Domain.Repositories;
using SimpleCommerce.Infrastructure.Repositories;
using System.Reflection;
using TransportGlobal.Infrastructure.Context;

namespace SimpleCommerce.Infrastructure.Expansions.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDBContext(configuration);

            services.RegisterRepositories();

            return services;
        }

        private static IServiceCollection RegisterDBContext(this IServiceCollection services, IConfiguration configuration)
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

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.Scan(scan =>
            {
                scan.FromAssembliesOf(typeof(Repository<>))
                    .AddClasses(classes => classes.AssignableTo(typeof(IRepository<>)))
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsImplementedInterfaces()
                    .WithScopedLifetime();
            });

            return services;
        }
    }
}
