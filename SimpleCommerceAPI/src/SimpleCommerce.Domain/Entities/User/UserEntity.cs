using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Domain.Entities.Address;
using SimpleCommerce.Domain.Entities.Order;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SimpleCommerce.Domain.Entities.User
{
    public class UserEntity : IdentityUser
    {
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Surname { get; set; }

        public bool IsActive { get; set; }

        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

        public List<AddressEntity> Addresses { get; set; } = new List<AddressEntity>();

        public UserEntity(string name, string surname, string email, bool isActive = true)
        {
            Name = name;
            Surname = surname;
            Email = email;
            IsActive = isActive;

            NormalizedEmail = email.ToUpper(new CultureInfo("en-US"));
            UserName = Email;
            NormalizedUserName = NormalizedEmail;
        }
    }
}
