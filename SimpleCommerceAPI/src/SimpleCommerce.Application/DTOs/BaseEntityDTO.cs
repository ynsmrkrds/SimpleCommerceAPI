namespace SimpleCommerce.Application.DTOs
{
    public abstract record BaseEntityDTO
    {
        public int ID { get; init; }

        public DateTime CreatedDate { get; init; }

        protected BaseEntityDTO(int id, DateTime createdDate)
        {
            ID = id;
            CreatedDate = createdDate;
        }
    }
}
