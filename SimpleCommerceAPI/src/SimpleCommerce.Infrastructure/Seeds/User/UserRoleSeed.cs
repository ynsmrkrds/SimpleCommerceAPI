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

            IdentityUserRole<string> normalUserRole = new()
            {
                UserId = "e2232222-a4ff-4ba6-bc41-327974fbdf4e",
                RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330",
            };

            builder.HasData(normalUserRole);
        }
    }
}
