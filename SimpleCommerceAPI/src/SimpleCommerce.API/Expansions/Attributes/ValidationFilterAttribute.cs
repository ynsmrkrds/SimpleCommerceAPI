using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SimpleCommerce.Domain.Models;
using System.Net;
using TransportGlobal.Application.DTOs.ResponseDTOs;

namespace SimpleCommerce.API.Expansions.Attributes
{
    public class ValidatationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                List<ExceptionConstantModel> exceptions = new();
                foreach (var item in context.ModelState)
                {
                    if (item.Value.Errors.Any())
                    {
                        string[] errorMessages = item.Value.Errors
                            .Select(error => error.ErrorMessage)
                            .ToArray();

                        exceptions.Add(new ExceptionConstantModel(errorMessages.Last()));
                    }
                }

                context.Result = new BadRequestObjectResult(new APIResponseDTO(HttpStatusCode.BadRequest, exceptions));
            }
        }
    }
}
