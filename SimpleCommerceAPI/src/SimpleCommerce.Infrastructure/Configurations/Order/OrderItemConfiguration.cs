using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Entities.Order;
using System.Reflection.Emit;

namespace SimpleCommerce.Infrastructure.Configurations.Order
{
    internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItemEntity>
    {
        public void Configure(EntityTypeBuilder<OrderItemEntity> builder)
        {
            builder.HasOne(x => x.Order)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.OrderID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Product)
               .WithMany(x => x.OrderItems)
               .HasForeignKey(x => x.ProductID)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
