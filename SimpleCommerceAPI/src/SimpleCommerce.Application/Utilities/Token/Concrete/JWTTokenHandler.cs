using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using SimpleCommerce.Application.Utilities.Token.Abstract;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Enums;
using SimpleCommerce.Domain.Exceptions;
using SimpleCommerce.Domain.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace SimpleCommerce.Application.Utilities.Token.Concrete
{
    public class JWTTokenHandler : ITokenHandler
    {
        private readonly JWTTokenConfigurationModel _tokenConfiguration;
        private static IHttpContextAccessor? _httpContextAccessor;

        public JWTTokenHandler(JWTTokenConfigurationModel tokenConfiguration, IHttpContextAccessor httpContextAccessor)
        {
            _tokenConfiguration = tokenConfiguration;
            _httpContextAccessor = httpContextAccessor;
        }

        public string CreateToken(TokenModel token)
        {
            Claim[] claims = new[]
            {
                new Claim("user_id", token.UserID),
                new Claim(JwtRegisteredClaimNames.Email, token.Email),
                new Claim(JwtRegisteredClaimNames.Name, token.Name),
                new Claim(JwtRegisteredClaimNames.FamilyName, token.Surname),
                new Claim(ClaimTypes.Role, token.Role.Value())
            };

            SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(_tokenConfiguration!.Key));

            SigningCredentials credentials = new(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwtToken = new(
                issuer: _tokenConfiguration.Issuer,
                audience: _tokenConfiguration.Audience,
                claims: claims,
                signingCredentials: credentials,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(_tokenConfiguration.DurationInMinutes))
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

        public TokenModel DecodeTokenInRequest()
        {
            string token = GetTokenInRequest();
            return DecodeToken(token);
        }

        private static string GetTokenInRequest()
        {
            string? token = _httpContextAccessor?.HttpContext?
                .Request
                .Headers[nameof(HttpRequestHeader.Authorization)]
                .ToString()
                .Replace("Bearer ", "");

            return token ?? throw new ClientSideException(ExceptionConstants.TokenError);
        }

        private static TokenModel DecodeToken(string token)
        {
            try
            {
                JwtSecurityTokenHandler handler = new();

                JwtSecurityToken jwtSecurityToken = handler.ReadJwtToken(token);

                string userId = jwtSecurityToken.Claims.First(x => x.Type == "user_id").Value;
                string email = jwtSecurityToken.Claims.First(x => x.Type == JwtRegisteredClaimNames.Email).Value;
                string name = jwtSecurityToken.Claims.First(x => x.Type == JwtRegisteredClaimNames.Name).Value;
                string surname = jwtSecurityToken.Claims.First(x => x.Type == JwtRegisteredClaimNames.FamilyName).Value;
                string role = jwtSecurityToken.Claims.First(x => x.Type == ClaimTypes.Role).Value;

                return new TokenModel(userId, email, name, surname, Enum.Parse<UserRole>(role));
            }
            catch (Exception)
            {
                throw new ClientSideException(ExceptionConstants.TokenError);
            }
        }
    }
}
