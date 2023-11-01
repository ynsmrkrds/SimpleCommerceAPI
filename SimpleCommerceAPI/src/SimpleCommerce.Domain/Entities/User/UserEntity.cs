using SimpleCommerce.Domain.Entities.Address;
using SimpleCommerce.Domain.Entities.Order;
using SimpleCommerce.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations;

namespace SimpleCommerce.Domain.Entities.User
{
    public class UserEntity : BaseEntity
    {
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Surname { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

        public List<AddressEntity> Addresses { get; set; } = new List<AddressEntity>();

        public UserEntity(string name, string surname, string email, string passwordHash)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PasswordHash = passwordHash;
        }
    }
}
