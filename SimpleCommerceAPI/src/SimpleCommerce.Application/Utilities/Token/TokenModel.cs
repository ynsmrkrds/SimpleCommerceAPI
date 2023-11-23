using SimpleCommerce.Domain.Enums;

namespace SimpleCommerce.Application.Utilities.Token
{
    public class TokenModel
    {
        public string UserID { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public UserRole Role { get; set; }

        public TokenModel(string userID, string email, string name, string surname, UserRole role)
        {
            UserID = userID;
            Email = email;
            Name = name;
            Surname = surname;
            Role = role;
        }
    }
}
