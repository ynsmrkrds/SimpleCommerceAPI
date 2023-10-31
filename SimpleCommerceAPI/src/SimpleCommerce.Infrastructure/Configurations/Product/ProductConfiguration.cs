using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Entities.Product;

namespace SimpleCommerce.Infrastructure.Configurations.Product
{
    internal class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasOne(x => x.Category)
               .WithMany(x => x.Products)
               .HasForeignKey(x => x.CategoryID)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.OrderItems)
               .WithOne(x => x.Product)
               .HasForeignKey(x => x.ProductID)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
