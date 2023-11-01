using MediatR;
using SimpleCommerce.Application.DTOs.Order;

namespace SimpleCommerce.Application.CQRSs.Order.CommandCreateOrder
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public List<OrderItemDTOForCreate> Items { get; set; }

        public CreateOrderCommandRequest(List<OrderItemDTOForCreate> items)
        {
            Items = items;
        }
    }
}
