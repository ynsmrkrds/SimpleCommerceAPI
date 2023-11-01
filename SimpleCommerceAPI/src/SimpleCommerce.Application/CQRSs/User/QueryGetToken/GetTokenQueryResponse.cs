using SimpleCommerce.Domain.Models;
using System.Text.Json.Serialization;

namespace SimpleCommerce.Application.CQRSs.User.QueryGetToken
{
    public class GetTokenQueryResponse
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Token { get; private set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ResponseConstantModel? Response { get; private set; }

        public GetTokenQueryResponse(string token)
        {
            Token = token;
        }

        public GetTokenQueryResponse(ResponseConstantModel response)
        {
            Response = response;
        }
    }
}
