namespace SimpleCommerce.Application.DTOs.Product
{
    public record ProductDTO : BaseEntityDTO
    {
        public string Name { get; init; }

        public string Description { get; init; }

        public decimal Price { get; init; }

        public int StockQuantity { get; init; }

        public ProductCategoryDTO Category { get; init; }

        public string ImageUrl { get; init; }

        public ProductDTO(int id, DateTime createdDate, string name, string description, decimal price, int stockQuantity, ProductCategoryDTO category, string imageUrl) : base(id, createdDate)
        {
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            Category = category;
            ImageUrl = imageUrl;
        }
    }
}
