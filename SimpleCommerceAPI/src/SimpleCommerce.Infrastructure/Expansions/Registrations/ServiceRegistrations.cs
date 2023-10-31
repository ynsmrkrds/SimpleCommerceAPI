using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleCommerce.Infrastructure.Expansions.Extensions;

namespace SimpleCommerce.Infrastructure.Expansions.Registrations
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDBContext(configuration);

            services.RegisterRepositories();

            return services;
        }
    }
}
