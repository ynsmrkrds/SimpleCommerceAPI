namespace SimpleCommerce.Application.DTOs.User
{
    public record UserDTO : BaseEntityDTO
    {
        public string Name { get; init; }

        public string Surname { get; init; }

        public string Email { get; init; }

        public UserDTO(int id, DateTime createdDate, bool isDeleted, string name, string surname, string email) : base(id, createdDate, isDeleted)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }
    }
}
