using SimpleCommerce.Application.Utilities.Token.Abstract;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Enums;

namespace SimpleCommerce.Application.Utilities.Token
{
    public class TokenUtility
    {
        private readonly ITokenHandler _tokenHandler;

        public TokenUtility(ITokenHandler tokenHandler)
        {
            _tokenHandler = tokenHandler;
        }

        public string CreateToken(UserEntity userEntity, UserRole role)
        {
            return _tokenHandler.CreateToken(
                new TokenModel(
                    userEntity.Id, 
                    userEntity.Email!, 
                    userEntity.Name, 
                    userEntity.Surname,
                    role)
                );
        }

        public TokenModel DecodeTokenInRequest()
        {
            return _tokenHandler.DecodeTokenInRequest();
        }
    }
}
