using Microsoft.AspNetCore.Mvc;
using SimpleCommerce.API.Expansions.Attributes;
using SimpleCommerce.Domain.Enums;
using SimpleCommerce.Domain.Models;
using System.Net;
using TransportGlobal.Application.DTOs.ResponseDTOs;

namespace TransportGlobal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorization(new UserRole[] { UserRole.User, UserRole.Admin })]
    public class BaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(T response)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;

            if (response!.GetType() == typeof(ResponseConstantModel))
            {
                return new ObjectResult(new APIResponseDTO(statusCode, (response as ResponseConstantModel)!))
                {
                    StatusCode = (int)statusCode
                };
            }

            return new ObjectResult(new APIResponseDTO(statusCode, response!))
            {
                StatusCode = (int)statusCode
            };
        }
    }
}
