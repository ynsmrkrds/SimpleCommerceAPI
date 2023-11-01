using AutoMapper;
using MediatR;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.Address;
using SimpleCommerce.Domain.Repositories.Address;

namespace SimpleCommerce.Application.CQRSs.Address.CommandCreateAddress
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, CreateAddressCommandResponse>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        private readonly TokenUtility _tokenUtility;

        public CreateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper, TokenUtility tokenUtility)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
            _tokenUtility = tokenUtility;
        }

        public Task<CreateAddressCommandResponse> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            int userID = _tokenUtility.DecodeTokenInRequest().UserID;

            if (_addressRepository.IsExistsWithSameTitle(request.Title, userID)) return Task.FromResult(new CreateAddressCommandResponse(ResponseConstants.ExistsAddressWithSameTitle));

            AddressEntity addressEntity = _mapper.Map<CreateAddressCommandRequest, AddressEntity>(request);
            addressEntity.UserID = userID;
            _addressRepository.Add(addressEntity);

            int effectedRows = _addressRepository.SaveChanges();
            if (effectedRows == 0) return Task.FromResult(new CreateAddressCommandResponse(ResponseConstants.CreateFailed));

            return Task.FromResult(new CreateAddressCommandResponse(ResponseConstants.SuccessfullyCreated));
        }
    }
}
