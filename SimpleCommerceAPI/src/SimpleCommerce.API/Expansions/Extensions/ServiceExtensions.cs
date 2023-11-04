using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SimpleCommerce.API.Expansions.Attributes;
using SimpleCommerce.Domain.Models;
using System.Text;

namespace TransportGlobal.API.Extensions.Registrations
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddAPILayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterFluentValidation();

            services.SetAuthentication(configuration);

            services.SetSwagger();

            services.RegisterCors();

            return services;
        }

        private static IServiceCollection RegisterFluentValidation(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new ValidatationFilterAttribute());
            });

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            return services;
        }

        private static IServiceCollection SetAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            JWTTokenConfigurationModel? tokenConfiguration = configuration.GetSection("JwtTokenSettings").Get<JWTTokenConfigurationModel>();
            if (tokenConfiguration != null)
            {
                services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                        .AddJwtBearer(options =>
                        {
                            options.SaveToken = true;
                            options.TokenValidationParameters = new TokenValidationParameters
                            {
                                ValidateIssuer = true,
                                ValidateAudience = true,
                                ValidateActor = true,
                                ValidateLifetime = true,
                                ClockSkew = TimeSpan.Zero,
                                ValidIssuer = tokenConfiguration.Issuer,
                                ValidAudience = tokenConfiguration.Audience,
                                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfiguration.Key))
                            };
                        });
            }

            return services;
        }

        private static IServiceCollection SetSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Simple Commerce API"
                });

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Description = "Bearer Authentication with JWT Token",
                    Type = SecuritySchemeType.Http
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference=new OpenApiReference
                            {
                                Id="Bearer",
                                Type=ReferenceType.SecurityScheme
                            },
                            In=ParameterLocation.Header,
                            Name="Bearer"
                        },
                        new List<string>()
                    }
                });
            });

            return services;
        }

        private static IServiceCollection RegisterCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            return services;
        }
    }
}
