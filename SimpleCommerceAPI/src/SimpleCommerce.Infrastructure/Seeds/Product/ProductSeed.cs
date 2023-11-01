using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Entities.Product;

namespace SimpleCommerce.Infrastructure.Seeds.Product
{
    internal class ProductSeed : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            List<ProductEntity> products = new()
            {
                // Products for electronics category
                new ProductEntity("Smartphone", "High-end smartphone with advanced features", 599.99M, 100, 1, "https://images.pexels.com/photos/63690/pexels-photo-63690.jpeg")
                {
                    ID = 1,
                },
                new ProductEntity("Laptop", "Powerful laptop for work and gaming", 1299.99M, 50, 1, "https://images.pexels.com/photos/6446709/pexels-photo-6446709.jpeg")
                {
                    ID = 2,
                },
                new ProductEntity("Headphones", "Noise-canceling headphones for an immersive audio experience", 149.99M, 200, 1, "https://images.pexels.com/photos/3394654/pexels-photo-3394654.jpeg")
                {
                    ID = 3,
                },

                // Products for clothing category
                new ProductEntity("T-Shirt", "Comfortable and stylish cotton t-shirt", 19.99M, 300, 2, "https://images.pexels.com/photos/8532616/pexels-photo-8532616.jpeg")
                {
                    ID = 4,
                },
                new ProductEntity("Jeans", "Classic denim jeans for a timeless look", 49.99M, 150, 2, "https://images.pexels.com/photos/4210864/pexels-photo-4210864.jpeg")
                {
                    ID = 5,
                },
                new ProductEntity("Dress", "Elegant evening dress for special occasions", 79.99M, 100, 2, "https://images.pexels.com/photos/1566435/pexels-photo-1566435.jpeg")
                {
                    ID = 6,
                },

                // Products for home appliances category
                new ProductEntity("Refrigerator", "Energy-efficient refrigerator with spacious storage", 699.99M, 50, 3, "https://images.pexels.com/photos/6996088/pexels-photo-6996088.jpeg")
                {
                    ID = 7,
                },
                new ProductEntity("Washing Machine", "Front-loading washing machine for clean laundry", 499.99M, 75, 3, "https://images.pexels.com/photos/5591460/pexels-photo-5591460.jpeg")
                {
                    ID = 8,
                },
                new ProductEntity("Microwave Oven", "Compact microwave oven for quick heating", 89.99M, 100, 3, "https://images.pexels.com/photos/211761/pexels-photo-211761.jpeg")
                {
                    ID = 9,
                },

                // Products for sports equipment category
                new ProductEntity("Running Shoes", "High-performance running shoes for athletes", 79.99M, 200, 4, "https://images.pexels.com/photos/2529148/pexels-photo-2529148.jpeg")
                {
                    ID = 10,
                },
                new ProductEntity("Yoga Mat", "Non-slip yoga mat for yoga and exercise routines", 29.99M, 150, 4, "https://images.pexels.com/photos/4498606/pexels-photo-4498606.jpeg")
                {
                    ID = 11,
                },
                new ProductEntity("Dumbbells", "Adjustable dumbbells for strength training", 99.99M, 100, 4, "https://images.pexels.com/photos/39671/physiotherapy-weight-training-dumbbell-exercise-balls-39671.jpeg")
                {
                    ID = 12,
                },

                // Products for jewelry category
                new ProductEntity("Diamond Ring", "Exquisite diamond ring for special occasions", 1499.99M, 50, 5, "https://images.pexels.com/photos/1457801/pexels-photo-1457801.jpeg")
                {
                    ID = 13,
                },
                new ProductEntity("Gold Necklace", "Elegant gold necklace with a timeless design", 799.99M, 75, 5, "https://images.pexels.com/photos/248077/pexels-photo-248077.jpeg")
                {
                    ID = 14,
                },
                new ProductEntity("Silver Bracelet", "Stylish silver bracelet for everyday wear", 149.99M, 100, 5, "https://images.pexels.com/photos/12026055/pexels-photo-12026055.jpeg")
                {
                    ID = 15,
                },
            };

            builder.HasData(products);
        }
    }
}
