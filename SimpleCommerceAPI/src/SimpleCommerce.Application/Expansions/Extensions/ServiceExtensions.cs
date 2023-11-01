using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Application.Utilities.Token.Concrete;
using SimpleCommerce.Domain.Models;
using System.Reflection;

namespace SimpleCommerce.Application.Expansions.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.RegisterTokenUtility(configuration);

            return services;
        }

        private static IServiceCollection RegisterTokenUtility(this IServiceCollection services, IConfiguration configuration)
        {
            JWTTokenConfigurationModel jwtTokenConfiguration = configuration.GetSection("JwtTokenSettings").Get<JWTTokenConfigurationModel>()!;
            IHttpContextAccessor httpContextAccessor = services.BuildServiceProvider().GetRequiredService<IHttpContextAccessor>();
            services.AddSingleton(_ => new TokenUtility(new JWTTokenHandler(jwtTokenConfiguration, httpContextAccessor)));

            return services;
        }
    }
}
