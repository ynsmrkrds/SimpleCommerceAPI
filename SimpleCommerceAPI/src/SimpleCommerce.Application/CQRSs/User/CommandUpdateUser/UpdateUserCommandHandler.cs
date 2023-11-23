using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Exceptions;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IMapper _mapper;
        private readonly TokenUtility _tokenUtility;

        public UpdateUserCommandHandler(UserManager<UserEntity> userManager, IMapper mapper, TokenUtility tokenUtility)
        {
            _userManager = userManager;
            _mapper = mapper;
            _tokenUtility = tokenUtility;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            string userID = _tokenUtility.DecodeTokenInRequest().UserID;

            UserEntity userEntity = await _userManager.FindByIdAsync(userID) ?? throw new ClientSideException(ExceptionConstants.NotFoundUser);
            _mapper.Map(request, userEntity);

            IdentityResult result = await _userManager.UpdateAsync(userEntity);

            return await Task.FromResult(new UpdateUserCommandResponse(result.Succeeded
                ? ResponseConstants.SuccessfullyUpdated
                : ResponseConstants.UpdateFailed));
        }
    }
}
