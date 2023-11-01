namespace SimpleCommerce.Application.DTOs.Order
{
    public record OrderItemDTOForCreate
    {
        public int ProductID { get; init; }

        public int Quantity { get; init; }

        public OrderItemDTOForCreate(int productID, int quantity)
        {
            ProductID = productID;
            Quantity = quantity;
        }
    }
}
