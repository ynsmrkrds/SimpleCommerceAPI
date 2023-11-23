using MediatR;
using Microsoft.AspNetCore.Identity;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Enums;
using SimpleCommerce.Domain.Exceptions;

namespace SimpleCommerce.Application.CQRSs.User.QueryHasAuthority
{
    public class HasAuthorityQueryHandler : IRequestHandler<HasAuthorityQueryRequest, HasAuthorityQueryResponse>
    {
        private readonly UserManager<UserEntity> _userManager;

        public HasAuthorityQueryHandler(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<HasAuthorityQueryResponse> Handle(HasAuthorityQueryRequest request, CancellationToken cancellationToken)
        {
            UserEntity userEntity = await _userManager.FindByIdAsync(request.UserId) ?? throw new NotFoundException(ExceptionConstants.NotFoundUser);

            bool isRolesMatch = false;

            foreach (UserRole role in request.Roles)
            {
                bool isInRole = await _userManager.IsInRoleAsync(userEntity, role.Value());
                if (isInRole)
                {
                    isRolesMatch = true;
                    break;
                }
            }

            return await Task.FromResult(new HasAuthorityQueryResponse(userEntity.IsActive, isRolesMatch));
        }
    }
}
