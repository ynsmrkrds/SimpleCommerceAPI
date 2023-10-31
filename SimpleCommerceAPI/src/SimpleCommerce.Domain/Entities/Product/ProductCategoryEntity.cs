using SimpleCommerce.Domain.SeedWorks;

namespace SimpleCommerce.Domain.Entities.Product
{
    public class ProductCategoryEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();

        public ProductCategoryEntity(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
