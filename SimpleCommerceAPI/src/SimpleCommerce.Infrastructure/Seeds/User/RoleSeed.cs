using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Enums;
using System.Globalization;

namespace SimpleCommerce.Infrastructure.Seeds.User
{
    internal class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            IdentityRole adminRole = new()
            {
                Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                Name = UserRole.Admin.Value(),
                NormalizedName = UserRole.Admin.Value().ToUpper(new CultureInfo("en-US"))
            };

            builder.HasData(adminRole);

            IdentityRole userRole = new()
            {
                Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                Name = UserRole.User.Value(),
                NormalizedName = UserRole.User.Value().ToUpper(new CultureInfo("en-US"))
            };

            builder.HasData(userRole);
        }
    }
}
