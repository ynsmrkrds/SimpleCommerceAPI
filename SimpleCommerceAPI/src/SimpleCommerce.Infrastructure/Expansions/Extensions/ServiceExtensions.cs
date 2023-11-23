using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using SimpleCommerce.Domain.Entities.User;
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

            services.RegisterIdentity();

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

        private static IServiceCollection RegisterIdentity (this IServiceCollection services)
        {
            services.AddIdentityCore<UserEntity>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<SimpleCommerceDBContext>()
            .AddSignInManager<SignInManager<UserEntity>>();

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
