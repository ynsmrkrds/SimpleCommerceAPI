using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Entities.Product;

namespace SimpleCommerce.Infrastructure.Seeds.Product
{
    internal class ProductCategorySeed : IEntityTypeConfiguration<ProductCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryEntity> builder)
        {
            List<ProductCategoryEntity> categories = new()
            {
                new ProductCategoryEntity("Electronics", "Electronics product category")
                {
                    ID = 1,
                },
                new ProductCategoryEntity("Clothing", "Clothing product category")
                {
                    ID = 2,
                },
                new ProductCategoryEntity("Home Appliances", "Home appliances category")
                {
                    ID = 3,
                },
                new ProductCategoryEntity("Sports Equipment", "Sports equipment category")
                {
                    ID = 4,
                },
                new ProductCategoryEntity("Jewelry", "Jewelry category")
                {
                    ID = 5,
                },
            };

            builder.HasData(categories);
        }
    }
}
