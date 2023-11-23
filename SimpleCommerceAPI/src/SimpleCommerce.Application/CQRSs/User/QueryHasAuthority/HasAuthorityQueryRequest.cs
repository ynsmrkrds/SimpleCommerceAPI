using MediatR;
using SimpleCommerce.Domain.Enums;

namespace SimpleCommerce.Application.CQRSs.User.QueryHasAuthority
{
    public class HasAuthorityQueryRequest : IRequest<HasAuthorityQueryResponse>
    {
        public string UserId { get; private set; }

        public UserRole[] Roles { get; private set; }

        public HasAuthorityQueryRequest(string userId, UserRole[] roles)
        {
            UserId = userId;
            Roles = roles;
        }
    }
}
