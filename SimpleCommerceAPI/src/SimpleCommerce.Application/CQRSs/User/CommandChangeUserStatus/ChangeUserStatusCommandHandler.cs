using MediatR;
using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Exceptions;

namespace SimpleCommerce.Application.CQRSs.User.CommandChangeUserStatus
{
    public class ChangeUserStatusCommandHandler : IRequestHandler<ChangeUserStatusCommandRequest, ChangeUserStatusCommandResponse>
    {
        private readonly UserManager<UserEntity> _userManager;

        public ChangeUserStatusCommandHandler(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ChangeUserStatusCommandResponse> Handle(ChangeUserStatusCommandRequest request, CancellationToken cancellationToken)
        {
            UserEntity userEntity = await _userManager.FindByIdAsync(request.UserId) ?? throw new NotFoundException(ExceptionConstants.NotFoundUser);
            userEntity.IsActive = request.IsActive;

            IdentityResult result = await _userManager.UpdateAsync(userEntity);

            return await Task.FromResult(new ChangeUserStatusCommandResponse(result.Succeeded
                   ? ResponseConstants.SuccessfullyUpdated
                   : ResponseConstants.UpdateFailed));
        }
    }
}
