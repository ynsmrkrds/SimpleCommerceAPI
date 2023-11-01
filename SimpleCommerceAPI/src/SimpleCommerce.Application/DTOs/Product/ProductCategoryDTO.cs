namespace SimpleCommerce.Application.DTOs.Product
{
    public record ProductCategoryDTO : BaseEntityDTO
    {
        public string Name { get; init; }

        public string Description { get; init; }

        public ProductCategoryDTO(int id, DateTime createdDate, string name, string description) : base(id, createdDate)
        {
            Name = name;
            Description = description;
        }
    }
}
