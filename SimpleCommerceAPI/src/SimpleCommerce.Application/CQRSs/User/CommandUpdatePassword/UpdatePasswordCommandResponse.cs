using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdatePassword
{
    public class UpdatePasswordCommandResponse : BaseCommandResponse
    {
        public UpdatePasswordCommandResponse(ResponseConstantModel response) : base(response)
        {
        }
    }
}
