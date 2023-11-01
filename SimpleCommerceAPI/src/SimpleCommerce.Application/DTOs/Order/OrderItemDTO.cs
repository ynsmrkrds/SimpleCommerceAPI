using SimpleCommerce.Application.DTOs.Product;

namespace SimpleCommerce.Application.DTOs.Order
{
    public record OrderItemDTO : BaseEntityDTO
    {
        public ProductDTO Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public OrderItemDTO(int id, DateTime createdDate, bool isDeleted, ProductDTO product, int quantity, decimal unitPrice) : base(id, createdDate, isDeleted)
        {
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
