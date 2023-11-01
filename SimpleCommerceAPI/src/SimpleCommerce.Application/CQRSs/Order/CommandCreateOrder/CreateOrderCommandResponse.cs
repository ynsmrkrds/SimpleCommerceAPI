using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.Order.CommandCreateOrder
{
    public class CreateOrderCommandResponse : BaseCommandResponse
    {
        public CreateOrderCommandResponse(ResponseConstantModel response) : base(response)
        {
        }
    }
}
