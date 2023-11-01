using MediatR;
using SimpleCommerce.Application.DTOs.Order;

namespace SimpleCommerce.Application.CQRSs.Order.CommandCreateOrder
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public int AddressID { get; set; }

        public List<OrderItemDTOForCreate> Items { get; set; }

        public CreateOrderCommandRequest(int addressID, List<OrderItemDTOForCreate> items)
        {
            AddressID = addressID;
            Items = items;
        }
    }
}
