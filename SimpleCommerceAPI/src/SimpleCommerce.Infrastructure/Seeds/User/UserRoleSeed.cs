using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SimpleCommerce.Infrastructure.Seeds.User
{
    internal class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            IdentityUserRole<string> adminUserRole = new()
            {
                UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                RoleId = "fab4fac1-c546-41de-aebc-a14da6895711",
            }; 

            builder.HasData(adminUserRole);
        }
    }
}
