using MediatR;
using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Exceptions;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdatePassword
{
    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommandRequest, UpdatePasswordCommandResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly TokenUtility _tokenUtility;

        public UpdatePasswordCommandHandler(UserManager<UserEntity> userManager, TokenUtility tokenUtility)
        {
            _userManager = userManager;
            _tokenUtility = tokenUtility;
        }

        public async Task<UpdatePasswordCommandResponse> Handle(UpdatePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            string userID = _tokenUtility.DecodeTokenInRequest().UserID;

            UserEntity userEntity = await _userManager.FindByIdAsync(userID) ?? throw new ClientSideException(ExceptionConstants.NotFoundUser);

            bool passwordsIsMatch = await _userManager.CheckPasswordAsync(userEntity, request.CurrentPassword);

            if (passwordsIsMatch == false) return await Task.FromResult(new UpdatePasswordCommandResponse(ResponseConstants.CurrentPasswordIncorrect));

            IdentityResult result = await _userManager.ChangePasswordAsync(userEntity, request.CurrentPassword, request.NewPassword);

            return await Task.FromResult(new UpdatePasswordCommandResponse(result.Succeeded
                    ? ResponseConstants.SuccessfullyUpdated
                    : ResponseConstants.UpdateFailed));
        }
    }
}
