using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.User.CommandCreateUser
{
    public class CreateUserCommandResponse : BaseCommandResponse
    {
        public CreateUserCommandResponse(ResponseConstantModel response) : base(response)
        {
        }
    }
}
