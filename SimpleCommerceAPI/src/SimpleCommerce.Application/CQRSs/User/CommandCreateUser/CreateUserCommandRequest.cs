using MediatR;
using System.ComponentModel.DataAnnotations;

namespace SimpleCommerce.Application.CQRSs.User.CommandCreateUser
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }

        public CreateUserCommandRequest(string name, string surname, string email, string password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }
    }
}
