namespace SimpleCommerce.Application.DTOs.Product
{
    public record ProductCategoryDTO : BaseEntityDTO
    {
        public string Name { get; init; }

        public string Description { get; init; }

        public ProductCategoryDTO(int id, DateTime createdDate, bool isDeleted, string name, string description) : base(id, createdDate, isDeleted)
        {
            Name = name;
            Description = description;
        }
    }
}
