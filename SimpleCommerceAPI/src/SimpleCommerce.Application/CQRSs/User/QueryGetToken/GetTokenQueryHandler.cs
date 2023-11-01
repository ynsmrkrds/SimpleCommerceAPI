using MediatR;
using SimpleCommerce.Application.CQRSs.User.QueryGetToken;
using SimpleCommerce.Application.Helpers;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Repositories.User;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.QueryGetToken
{
    public class GetTokenQueryHandler : IRequestHandler<GetTokenQueryRequest, GetTokenQueryResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly TokenUtility _tokenUtility;

        public GetTokenQueryHandler(IUserRepository userRepository, TokenUtility tokenUtility)
        {
            _userRepository = userRepository;
            _tokenUtility = tokenUtility;
        }

        public Task<GetTokenQueryResponse> Handle(GetTokenQueryRequest request, CancellationToken cancellationToken)
        {
            string passwordHash = EncryptionHelper.Encrypt(request.Password);

            UserEntity? userEntity = _userRepository.ValidateUser(request.Email, passwordHash);
            if (userEntity == null) return Task.FromResult(new GetTokenQueryResponse(ResponseConstants.EmailOrPasswordIncorrect));

            string token = _tokenUtility.CreateToken(userEntity);

            return Task.FromResult(new GetTokenQueryResponse(token));
        }
    }
}
