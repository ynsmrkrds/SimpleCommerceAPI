using MediatR;
using SimpleCommerce.Application.Helpers;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Exceptions;
using SimpleCommerce.Domain.Repositories.User;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdatePassword
{
    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommandRequest, UpdatePasswordCommandResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly TokenUtility _tokenUtility;

        public UpdatePasswordCommandHandler(IUserRepository userRepository, TokenUtility tokenUtility)
        {
            _userRepository = userRepository;
            _tokenUtility = tokenUtility;
        }

        public Task<UpdatePasswordCommandResponse> Handle(UpdatePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            int userID = _tokenUtility.DecodeTokenInRequest().UserID;

            UserEntity userEntity = _userRepository.GetByID(userID) ?? throw new ClientSideException(ExceptionConstants.NotFoundUser);
            if (userEntity.PasswordHash != EncryptionHelper.Encrypt(request.CurrentPassword)) return Task.FromResult(new UpdatePasswordCommandResponse(ResponseConstants.CurrentPasswordIncorrect));

            userEntity.PasswordHash = EncryptionHelper.Encrypt(request.NewPassword);
            _userRepository.Update(userEntity);

            int effectedRows = _userRepository.SaveChanges();
            if (effectedRows == 0) return Task.FromResult(new UpdatePasswordCommandResponse(ResponseConstants.UpdateFailed));

            return Task.FromResult(new UpdatePasswordCommandResponse(ResponseConstants.SuccessfullyUpdated));
        }
    }
}
