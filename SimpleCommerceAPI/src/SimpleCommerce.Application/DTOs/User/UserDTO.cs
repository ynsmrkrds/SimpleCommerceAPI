namespace SimpleCommerce.Application.DTOs.User
{
    public record UserDTO : BaseEntityDTO
    {
        public string Name { get; init; }

        public string Surname { get; init; }

        public string Email { get; init; }

        public UserDTO(int id, DateTime createdDate, string name, string surname, string email) : base(id, createdDate)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }
    }
}
