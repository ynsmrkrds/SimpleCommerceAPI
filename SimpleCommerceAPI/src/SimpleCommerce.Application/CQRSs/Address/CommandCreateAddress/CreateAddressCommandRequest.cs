using MediatR;
using System.ComponentModel.DataAnnotations;

namespace SimpleCommerce.Application.CQRSs.Address.CommandCreateAddress
{
    public class CreateAddressCommandRequest : IRequest<CreateAddressCommandResponse>
    {
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

        public CreateAddressCommandRequest(string title, string city, string district, string street, string address)
        {
            Title = title;
            City = city;
            District = district;
            Street = street;
            Address = address;
        }
    }
}
