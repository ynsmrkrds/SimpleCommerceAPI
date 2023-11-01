namespace SimpleCommerce.Application.DTOs.Order
{
    public record OrderDTO
    {
        public List<OrderItemDTO> Items { get; init; }

        public decimal TotalPrice { get; init; }

        public OrderDTO(List<OrderItemDTO> items, decimal totalPrice)
        {
            Items = items;
            TotalPrice = totalPrice;
        }
    }
}
