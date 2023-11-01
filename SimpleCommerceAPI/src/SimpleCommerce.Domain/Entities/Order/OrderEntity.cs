using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCommerce.Domain.Entities.Order
{
    public class OrderEntity : BaseEntity
    {
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        public UserEntity? User { get; set; }

        public List<OrderItemEntity> Items { get; set; } = new List<OrderItemEntity>();

        public OrderEntity(int userID)
        {
            UserID = userID;
        }

        public decimal TotalPrice => Items.Select(item => item.Product!.Price * item.Quantity).Sum();

        public void AddItem(OrderItemEntity item)
        {
            OrderItemEntity? itemInList = Items.Where(x => x.ProductID == item.ProductID).FirstOrDefault();
            if (itemInList == null)
            {
                Items.Add(item);
            }
            else
            {
                itemInList.Quantity++;
            }
        }

        public void AddItems(List<OrderItemEntity> items)
        {
            foreach (OrderItemEntity item in items)
            {
                AddItem(item);
            }
        }

        public void RemoveItem(OrderItemEntity item)
        {
            Items.Remove(item);
        }
    }
}
