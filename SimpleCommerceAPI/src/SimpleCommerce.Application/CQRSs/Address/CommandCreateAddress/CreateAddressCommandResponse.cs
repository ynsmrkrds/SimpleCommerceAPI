using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.Address.CommandCreateAddress
{
    public class CreateAddressCommandResponse : BaseCommandResponse
    {
        public CreateAddressCommandResponse(ResponseConstantModel response) : base(response)
        {
        }
    }
}
