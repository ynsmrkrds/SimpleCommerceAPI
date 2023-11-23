using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Application.DTOs.User;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Entities.User;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.QueryGetProfile
{
    public class GetProfileQueryHandler : IRequestHandler<GetProfileQueryRequest, GetProfileQueryResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IMapper _mapper;
        private readonly TokenUtility _tokenUtility;

        public GetProfileQueryHandler(UserManager<UserEntity> userManager, IMapper mapper, TokenUtility tokenUtility)
        {
            _userManager = userManager;
            _mapper = mapper;
            _tokenUtility = tokenUtility;
        }

        public async Task<GetProfileQueryResponse> Handle(GetProfileQueryRequest request, CancellationToken cancellationToken)
        {
            string userID = _tokenUtility.DecodeTokenInRequest().UserID;

            UserEntity userEntity = (await _userManager.FindByIdAsync(userID))!;
            UserDTO userDTO = _mapper.Map<UserDTO>(userEntity);

            return await Task.FromResult(new GetProfileQueryResponse(userDTO));
        }
    }
}
