using AutoMapper;
using MediatR;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Exceptions;
using SimpleCommerce.Domain.Repositories.User;

namespace TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly TokenUtility _tokenUtility;

        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper, TokenUtility tokenUtility)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _tokenUtility = tokenUtility;
        }

        public Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            int userID = _tokenUtility.DecodeTokenInRequest().UserID;

            UserEntity userEntity = _userRepository.GetByID(userID) ?? throw new ClientSideException(ExceptionConstants.NotFoundUser);
            _mapper.Map(request, userEntity);
            _userRepository.Update(userEntity);

            int effectedRows = _userRepository.SaveChanges();
            if (effectedRows == 0) return Task.FromResult(new UpdateUserCommandResponse(ResponseConstants.UpdateFailed));

            return Task.FromResult(new UpdateUserCommandResponse(ResponseConstants.SuccessfullyUpdated));
        }
    }
}
