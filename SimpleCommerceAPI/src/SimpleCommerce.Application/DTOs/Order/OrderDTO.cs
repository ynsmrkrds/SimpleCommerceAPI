using SimpleCommerce.Application.DTOs.Address;

namespace SimpleCommerce.Application.DTOs.Order
{
    public record OrderDTO
    {
        public AddressDTO Address { get; init; }

        public List<OrderItemDTO> Items { get; init; }

        public decimal TotalPrice { get; init; }

        public OrderDTO(AddressDTO address, List<OrderItemDTO> items, decimal totalPrice)
        {
            Address = address;
            Items = items;
            TotalPrice = totalPrice;
        }
    }
}
