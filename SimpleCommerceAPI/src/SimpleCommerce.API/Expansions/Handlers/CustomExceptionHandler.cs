using Microsoft.AspNetCore.Diagnostics;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Exceptions;
using SimpleCommerce.Domain.Models;
using System.Net;
using System.Net.Mime;
using System.Text.Json;
using TransportGlobal.Application.DTOs.ResponseDTOs;

namespace SimpleCommerce.API.Expansions.Handlers
{
    public static class CustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    IExceptionHandlerFeature? exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (exceptionFeature == null) return;

                    HttpStatusCode statusCode = exceptionFeature.Error switch
                    {
                        ClientSideException => HttpStatusCode.BadRequest,
                        NotFoundException => HttpStatusCode.NotFound,
                        _ => HttpStatusCode.InternalServerError,
                    };

                    ExceptionConstantModel exceptionConstant = statusCode switch
                    {
                        HttpStatusCode.InternalServerError => ExceptionConstants.ServerSideException,
                        _ => exceptionFeature.Error is not ClientSideException clientSideException ? ExceptionConstants.ServerSideException : new ExceptionConstantModel(clientSideException.Message)
                    };

                    context.Response.StatusCode = (int)statusCode;

                    APIResponseDTO response = new(statusCode, exceptionConstant);

                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}
