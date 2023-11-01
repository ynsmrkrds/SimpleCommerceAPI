namespace SimpleCommerce.Application.DTOs
{
    public abstract record BaseEntityDTO
    {
        public int ID { get; init; }

        public DateTime CreatedDate { get; init; }

        public bool IsDeleted { get; init; }

        protected BaseEntityDTO(int id, DateTime createdDate, bool isDeleted)
        {
            ID = id;
            CreatedDate = createdDate;
            IsDeleted = isDeleted;
        }
    }
}
