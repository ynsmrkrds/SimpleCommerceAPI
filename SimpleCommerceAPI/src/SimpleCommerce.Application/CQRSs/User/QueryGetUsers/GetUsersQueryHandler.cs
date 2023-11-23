using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Application.DTOs.User;
using SimpleCommerce.Domain.Entities.User;

namespace SimpleCommerce.Application.CQRSs.User.QueryGetUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQueryRequest, GetUsersQueryResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IMapper _mapper;

        public GetUsersQueryHandler(UserManager<UserEntity> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public Task<GetUsersQueryResponse> Handle(GetUsersQueryRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<UserEntity> users = _userManager.Users.Where(x => x.Email != "admin@xyz.com");

            IEnumerable<UserDTO> dtos = _mapper.Map<IEnumerable<UserDTO>>(users);

            return Task.FromResult(new GetUsersQueryResponse(dtos, request.Pagination));
        }
    }
}
