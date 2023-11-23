using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using SimpleCommerce.Application.CQRSs.User.QueryHasAuthority;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Enums;
using SimpleCommerce.Domain.Exceptions;
using System.Net;

namespace SimpleCommerce.API.Expansions.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class AuthorizationAttribute : ActionFilterAttribute
    {
        private readonly UserRole[] _roles;

        public AuthorizationAttribute(UserRole[] roles)
        {
            _roles = roles;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (IsMethodAnonymous(context)) return;

            TokenModel tokenModel;
            try
            {
                IServiceProvider serviceProvider = context.HttpContext.RequestServices;

                TokenUtility tokenUtility = serviceProvider.GetRequiredService<TokenUtility>();

                tokenModel = tokenUtility.DecodeTokenInRequest();
            }
            catch (Exception)
            {
                context.Result = new ObjectResult(null)
                {
                    StatusCode = (int)HttpStatusCode.Unauthorized
                };
                return;
            }

            IMediator mediator = context.HttpContext.RequestServices.GetRequiredService<IMediator>();
            HasAuthorityQueryResponse queryResponse = mediator.Send(new HasAuthorityQueryRequest(tokenModel.UserID, _roles)).Result;
            if (queryResponse.HasAuthority == false)
            {
                context.Result = new ObjectResult(null)
                {
                    StatusCode = (int)HttpStatusCode.Forbidden
                };
                return;
            }
        }

        private static bool IsMethodAnonymous(ActionExecutingContext context)
        {
            if (context.ActionDescriptor is ControllerActionDescriptor descriptor)
            {
                return descriptor.MethodInfo
                    .GetCustomAttributes(inherit: true)
                    .Any(x => x.GetType() == typeof(AllowAnonymousAttribute));
            }

            return false;
        }
    }
}
