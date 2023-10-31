using SimpleCommerce.Domain.Entities.Product;
using SimpleCommerce.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCommerce.Domain.Entities.Order
{
    public class OrderItemEntity : BaseEntity
    {
        [ForeignKey(nameof(Order))]
        public int OrderID { get; set; }

        public OrderEntity? Order { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductID { get; set; }

        public ProductEntity? Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public OrderItemEntity(int orderID, int productID, int quantity, decimal unitPrice)
        {
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
