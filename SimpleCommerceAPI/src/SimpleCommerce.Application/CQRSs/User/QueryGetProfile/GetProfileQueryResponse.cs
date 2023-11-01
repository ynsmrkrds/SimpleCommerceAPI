using SimpleCommerce.Application.DTOs.User;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.QueryGetProfile
{
    public class GetProfileQueryResponse
    {
        public UserDTO Profile { get; set; }

        public GetProfileQueryResponse(UserDTO profile)
        {
            Profile = profile;
        }
    }
}
