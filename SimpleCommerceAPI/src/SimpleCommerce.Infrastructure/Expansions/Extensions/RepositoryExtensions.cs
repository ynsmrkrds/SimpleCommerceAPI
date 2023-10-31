using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using SimpleCommerce.Domain.Repositories;
using SimpleCommerce.Infrastructure.Repositories;

namespace SimpleCommerce.Infrastructure.Expansions.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
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
