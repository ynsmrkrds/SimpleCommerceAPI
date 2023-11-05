using SimpleCommerce.Application.DTOs.Address;

namespace SimpleCommerce.Application.DTOs.Order
{
    public record OrderDTO : BaseEntityDTO
    {
        public AddressDTO Address { get; init; }

        public List<OrderItemDTO> Items { get; init; }

        public decimal TotalPrice { get; init; }

        public OrderDTO(int id, DateTime createdDate, AddressDTO address, List<OrderItemDTO> items, decimal totalPrice) : base(id, createdDate)
        {
            Address = address;
            Items = items;
            TotalPrice = totalPrice;
        }
    }
}
