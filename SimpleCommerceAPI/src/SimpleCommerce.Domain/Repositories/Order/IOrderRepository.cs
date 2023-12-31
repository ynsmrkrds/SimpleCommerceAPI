﻿using SimpleCommerce.Domain.Entities.Order;

namespace SimpleCommerce.Domain.Repositories.Order
{
    public interface IOrderRepository : IRepository<OrderEntity>
    {
        IEnumerable<OrderEntity> GetAllByUserID(string userID);
    }
}
