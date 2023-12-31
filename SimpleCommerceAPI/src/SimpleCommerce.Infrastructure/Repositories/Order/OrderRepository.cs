﻿using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<OrderEntity> GetAllByUserID(string userID)
        {
            return GetAll()
                .Include(x => x.User)
                .Include(x => x.Address)
                .Include(x => x.Items)
                .ThenInclude(x => x.Product)
                .Where(x => x.UserID == userID);
        }
    }
}
