using SimpleCommerce.Application.Utilities.Token.Abstract;
using SimpleCommerce.Domain.Entities.User;

namespace SimpleCommerce.Application.Utilities.Token
{
    public class TokenUtility
    {
        private readonly ITokenHandler _tokenHandler;

        public TokenUtility(ITokenHandler tokenHandler)
        {
            _tokenHandler = tokenHandler;
        }

        public string CreateToken(UserEntity userEntity)
        {
            return _tokenHandler.CreateToken(
                new TokenModel(
                    userEntity.ID, 
                    userEntity.Email, 
                    userEntity.Name, 
                    userEntity.Surname)
                );
        }

        public TokenModel DecodeTokenInRequest()
        {
            return _tokenHandler.DecodeTokenInRequest();
        }
    }
}
