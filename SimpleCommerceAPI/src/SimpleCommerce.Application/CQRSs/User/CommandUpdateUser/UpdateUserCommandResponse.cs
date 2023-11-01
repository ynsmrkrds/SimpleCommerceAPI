using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdateUser
{
    public class UpdateUserCommandResponse : BaseCommandResponse
    {
        public UpdateUserCommandResponse(ResponseConstantModel response) : base(response)
        {
        }
    }
}
