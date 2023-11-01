using System.ComponentModel.DataAnnotations;

namespace SimpleCommerce.Application.DTOs.Address
{
    public record AddressDTO : BaseEntityDTO
    {
        public string Title { get; init; }

        public string City { get; init; }

        public string District { get; init; }

        public string Street { get; init; }

        public string Address { get; init; }

        public AddressDTO(int id, DateTime createdDate, string title, string city, string district, string street, string address) : base(id, createdDate)
        {
            Title = title;
            City = city;
            District = district;
            Street = street;
            Address = address;
        }
    }
}
