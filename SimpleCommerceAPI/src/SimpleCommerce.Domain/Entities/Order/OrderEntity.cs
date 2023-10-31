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

        public decimal TotalPrice => Items.Select(item => item.UnitPrice * item.Quantity).Sum();

        public void AddItem(OrderItemEntity item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItemEntity item)
        {
            Items.Remove(item);
        }
    }
}
