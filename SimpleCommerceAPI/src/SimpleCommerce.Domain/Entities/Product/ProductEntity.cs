using SimpleCommerce.Domain.Entities.Order;
using SimpleCommerce.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCommerce.Domain.Entities.Product
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryID { get; set; }

        public ProductCategoryEntity? Category { get; set; }

        public string ImageUrl { get; set; }

        public List<OrderItemEntity> OrderItems { get; set; } = new List<OrderItemEntity>();

        public ProductEntity(string name, string description, decimal price, int stockQuantity, int categoryID, string imageUrl)
        {
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            CategoryID = categoryID;
            ImageUrl = imageUrl;
        }
    }
}
