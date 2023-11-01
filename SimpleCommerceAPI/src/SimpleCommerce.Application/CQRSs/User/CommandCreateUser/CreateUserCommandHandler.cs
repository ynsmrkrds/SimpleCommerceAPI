using AutoMapper;
using MediatR;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Repositories.User;

namespace SimpleCommerce.Application.CQRSs.User.CommandCreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            if (_userRepository.IsExistsWithSameEmail(request.Email)) return Task.FromResult(new CreateUserCommandResponse(ResponseConstants.ExistsUserWithSameEmail));

            UserEntity userEntity = _mapper.Map<UserEntity>(request);
            _userRepository.Add(userEntity);

            int effectedRows = _userRepository.SaveChanges();
            if (effectedRows == 0) return Task.FromResult(new CreateUserCommandResponse(ResponseConstants.CreateFailed));

            return Task.FromResult(new CreateUserCommandResponse(ResponseConstants.SuccessfullyCreated));
        }
    }
}
