using SimpleCommerce.Domain.Entities.Order;
using SimpleCommerce.Domain.Repositories.Order;
using TransportGlobal.Infrastructure.Context;

namespace SimpleCommerce.Infrastructure.Repositories.Order
{
    public class OrderRepository : Repository<OrderEntity>, IOrderRepository
    {
        public OrderRepository(SimpleCommerceDBContext context) : base(context)
        {
        }
    }
}
