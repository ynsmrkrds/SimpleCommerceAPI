using SimpleCommerce.Domain.Entities.Order;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCommerce.Domain.Entities.Address
{
    public class AddressEntity : BaseEntity
    {
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        public UserEntity? User { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string City { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string District { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Street { get; set; }

        [StringLength(50, MinimumLength = 6)]
        public string Address { get; set; }

        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

        public AddressEntity(int userID, string title, string city, string district, string street, string address)
        {
            UserID = userID;
            Title = title;
            City = city;
            District = district;
            Street = street;
            Address = address;
        }
    }
}
