using MediatR;
using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Application.CQRSs.User.QueryGetToken;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Enums;
using SimpleCommerce.Domain.Exceptions;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.QueryGetToken
{
    public class GetTokenQueryHandler : IRequestHandler<GetTokenQueryRequest, GetTokenQueryResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly TokenUtility _tokenUtility;

        public GetTokenQueryHandler(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, TokenUtility tokenUtility)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenUtility = tokenUtility;
        }

        public async Task<GetTokenQueryResponse> Handle(GetTokenQueryRequest request, CancellationToken cancellationToken)
        {
            UserEntity userEntity = await _userManager.FindByEmailAsync(request.Email) ?? throw new NotFoundException(ExceptionConstants.NotFoundUser);

            SignInResult signInResult = await _signInManager.CheckPasswordSignInAsync(userEntity, request.Password, false);
            if (signInResult.Succeeded == false) return await Task.FromResult(new GetTokenQueryResponse(ResponseConstants.EmailOrPasswordIncorrect));

            string userRole = (await _userManager.GetRolesAsync(userEntity)).First();

            string token = _tokenUtility.CreateToken(userEntity, Enum.Parse<UserRole>(userRole));
            return await Task.FromResult(new GetTokenQueryResponse(token));
        }
    }
}
