namespace SimpleCommerce.Application.Utilities.Token.Abstract
{
    public interface ITokenHandler
    {
        string CreateToken(TokenModel user);

        TokenModel DecodeTokenInRequest();
    }
}
