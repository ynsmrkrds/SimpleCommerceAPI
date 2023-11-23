namespace SimpleCommerce.Domain.Enums
{
    public enum UserRole
    {
        Admin,
        User
    }

    public static class UserRoleExtensions
    {
        public static string Value(this UserRole userRole)
        {
            return userRole switch
            {
                UserRole.Admin => "Admin",
                UserRole.User => "User",
                _ => throw new NotImplementedException()
            };
        }
    }
}
