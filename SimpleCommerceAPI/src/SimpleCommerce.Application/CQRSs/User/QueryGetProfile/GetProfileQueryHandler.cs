using AutoMapper;
using MediatR;
using SimpleCommerce.Application.DTOs.User;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Repositories.User;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.QueryGetProfile
{
    public class GetProfileQueryHandler : IRequestHandler<GetProfileQueryRequest, GetProfileQueryResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly TokenUtility _tokenUtility;

        public GetProfileQueryHandler(IUserRepository userRepository, IMapper mapper, TokenUtility tokenUtility)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _tokenUtility = tokenUtility;
        }

        public Task<GetProfileQueryResponse> Handle(GetProfileQueryRequest request, CancellationToken cancellationToken)
        {
            int userID = _tokenUtility.DecodeTokenInRequest().UserID;

            UserEntity userEntity = _userRepository.GetByID(userID)!;
            UserDTO userDTO = _mapper.Map<UserDTO>(userEntity);

            return Task.FromResult(new GetProfileQueryResponse(userDTO));
        }
    }
}
