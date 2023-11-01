using SimpleCommerce.Domain.Models;

namespace TransportGlobal.Application.DTOs.CQRSDTOs
{
    public abstract class BaseCommandResponse
    {
        public ResponseConstantModel Response { get; private set; }

        public BaseCommandResponse(ResponseConstantModel response)
        {
            Response = response;
        }
    }
}
