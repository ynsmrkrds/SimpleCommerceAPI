using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Enums;

namespace SimpleCommerce.Application.CQRSs.User.CommandCreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(UserManager<UserEntity> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            if (_userManager.Users.Any(u => u.Email == request.Email)) return await Task.FromResult(new CreateUserCommandResponse(ResponseConstants.ExistsUserWithSameEmail));

            UserEntity userEntity = _mapper.Map<UserEntity>(request);            

            IdentityResult result = await _userManager.CreateAsync(userEntity, request.Password);

            await _userManager.AddToRoleAsync(userEntity, UserRole.User.Value());

            return await Task.FromResult(new CreateUserCommandResponse(result.Succeeded
                    ? ResponseConstants.SuccessfullyCreated
                    : ResponseConstants.CreateFailed));
        }
    }
}
