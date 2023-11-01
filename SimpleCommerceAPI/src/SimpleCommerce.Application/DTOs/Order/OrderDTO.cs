using SimpleCommerce.Application.DTOs.User;

namespace SimpleCommerce.Application.DTOs.Order
{
    public record OrderDTO
    {
        public UserDTO User { get; init; }

        public List<OrderItemDTO> Items { get; init; }

        public decimal TotalPrice { get; init; }

        public OrderDTO(UserDTO user, List<OrderItemDTO> items, decimal totalPrice)
        {
            User = user;
            Items = items;
            TotalPrice = totalPrice;
        }
    }
}
