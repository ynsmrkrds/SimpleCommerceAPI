namespace SimpleCommerce.Application.DTOs.User
{
    public record UserDTO
    {
        public string Id { get; set; }

        public string Name { get; init; }

        public string Surname { get; init; }

        public string Email { get; init; }

        public bool IsActive { get; init; }

        public UserDTO(string id, string name, string surname, string email, bool isActive)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            IsActive = isActive;
        }
    }
}
