using SimpleCommerce.Application.DTOs.Product;

namespace SimpleCommerce.Application.DTOs.Order
{
    public record OrderItemDTO : BaseEntityDTO
    {
        public ProductDTO Product { get; init; }

        public int Quantity { get; init; }

        public OrderItemDTO(int id, DateTime createdDate, ProductDTO product, int quantity) : base(id, createdDate)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
