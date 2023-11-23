using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleCommerce.API.Expansions.Attributes;
using SimpleCommerce.Application.CQRSs.User.CommandChangeUserStatus;
using SimpleCommerce.Application.CQRSs.User.CommandCreateUser;
using SimpleCommerce.Application.CQRSs.User.QueryGetToken;
using SimpleCommerce.Application.CQRSs.User.QueryGetUsers;
using SimpleCommerce.Domain.Enums;
using SimpleCommerce.Domain.Models;
using TransportGlobal.API.Controllers;
using TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdatePassword;
using TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdateUser;
using TransportGlobal.Application.CQRSs.UserContextCQRSs.QueryGetProfile;
using TransportGlobal.Application.CQRSs.UserContextCQRSs.QueryGetToken;

namespace SimpleCommerce.API.Controllers
{
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{page}/{size}")]
        [Authorization(new UserRole[] { UserRole.Admin })]
        public async Task<IActionResult> GetAll(int page, int size)
        {
            GetUsersQueryResponse queryResponse = await _mediator.Send(new GetUsersQueryRequest(new PaginationModel(page, size)));
            return CreateActionResult(queryResponse);
        }

        [HttpGet]
        [Route("profile")]
        public async Task<IActionResult> GetProfile()
        {
            GetProfileQueryResponse queryResponse = await _mediator.Send(new GetProfileQueryRequest());
            return CreateActionResult(queryResponse.Profile);
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] GetTokenQueryRequest request)
        {
            GetTokenQueryResponse commandResponse = await _mediator.Send(request);
            if (commandResponse.Response != null) return CreateActionResult(commandResponse.Response);

            return CreateActionResult(commandResponse);
        }

        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] CreateUserCommandRequest request)
        {
            CreateUserCommandResponse commandResponse = await _mediator.Send(request);
            return CreateActionResult(commandResponse.Response);
        }

        [HttpPut]
        [Route("updateProfile")]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateUserCommandRequest request)
        {
            UpdateUserCommandResponse commandResponse = await _mediator.Send(request);
            return CreateActionResult(commandResponse.Response);
        }

        [HttpPut]
        [Route("updatePassword")]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordCommandRequest request)
        {
            UpdatePasswordCommandResponse commandResponse = await _mediator.Send(request);
            return CreateActionResult(commandResponse.Response);
        }

        [HttpPut]
        [Route("changeUserStatus")]
        [Authorization(new UserRole[] { UserRole.Admin })]
        public async Task<IActionResult> ChangeUserStatus([FromBody] ChangeUserStatusCommandRequest request)
        {
            ChangeUserStatusCommandResponse commandResponse = await _mediator.Send(request);
            return CreateActionResult(commandResponse.Response);
        }
    }
}
