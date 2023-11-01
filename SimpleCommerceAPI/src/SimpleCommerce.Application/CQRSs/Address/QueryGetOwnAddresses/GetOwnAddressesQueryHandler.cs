using AutoMapper;
using MediatR;
using SimpleCommerce.Application.DTOs.Address;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Entities.Address;
using SimpleCommerce.Domain.Repositories.Address;

namespace SimpleCommerce.Application.CQRSs.Address.QueryGetOwnAddresses
{
    public class GetOwnAddressesQueryHandler : IRequestHandler<GetOwnAddressesQueryRequest, GetOwnAddressesQueryResponse>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        private readonly TokenUtility _tokenUtility;

        public GetOwnAddressesQueryHandler(IAddressRepository addressRepository, IMapper mapper, TokenUtility tokenUtility)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
            _tokenUtility = tokenUtility;
        }

        public Task<GetOwnAddressesQueryResponse> Handle(GetOwnAddressesQueryRequest request, CancellationToken cancellationToken)
        {
            int userID = _tokenUtility.DecodeTokenInRequest().UserID;

            IEnumerable<AddressEntity> addresses = _addressRepository.GetAllByUserID(userID);

            IEnumerable<AddressDTO> dtos = _mapper.Map<IEnumerable<AddressDTO>>(addresses);

            return Task.FromResult(new GetOwnAddressesQueryResponse(dtos, request.Pagination));
        }
    }
}
