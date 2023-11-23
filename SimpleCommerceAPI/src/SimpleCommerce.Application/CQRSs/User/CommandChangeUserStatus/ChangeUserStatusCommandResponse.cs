using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.User.CommandChangeUserStatus
{
    public class ChangeUserStatusCommandResponse : BaseCommandResponse
    {
        public ChangeUserStatusCommandResponse(ResponseConstantModel response) : base(response)
        {
        }
    }
}
