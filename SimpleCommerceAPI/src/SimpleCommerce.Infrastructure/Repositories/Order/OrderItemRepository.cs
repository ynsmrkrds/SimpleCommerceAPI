using SimpleCommerce.Domain.Entities.Order;
using SimpleCommerce.Domain.Repositories.Order;
using TransportGlobal.Infrastructure.Context;

namespace SimpleCommerce.Infrastructure.Repositories.Order
{
    public class OrderItemRepository : Repository<OrderItemEntity>, IOrderItemRepository
    {
        public OrderItemRepository(SimpleCommerceDBContext context) : base(context)
        {
        }
    }
}
