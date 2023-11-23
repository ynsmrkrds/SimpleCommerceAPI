namespace SimpleCommerce.Application.CQRSs.User.QueryHasAuthority
{
    public class HasAuthorityQueryResponse
    {
        public bool IsProfileActive { get; set; }

        public bool IsRolesMatch { get; set; }

        public HasAuthorityQueryResponse(bool isProfileActive, bool isRolesMatch)
        {
            IsProfileActive = isProfileActive;
            IsRolesMatch = isRolesMatch;
        }

        public bool HasAuthority => IsProfileActive && IsRolesMatch;
    }
}
