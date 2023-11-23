using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Entities.User;

namespace SimpleCommerce.Infrastructure.Seeds.User
{
    internal class UserSeed : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            UserEntity adminUser = new("Admin", "ADMIN", "admin@xyz.com")
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
            };

            PasswordHasher<UserEntity> passwordHasher = new();
            string passwordHash = passwordHasher.HashPassword(adminUser, "123456");

            adminUser.PasswordHash = passwordHash;

            builder.HasData(adminUser);

            UserEntity normalUser = new("John", "DOE", "john.doe@xyz.com")
            {
                Id = "e2232222-a4ff-4ba6-bc41-327974fbdf4e",
            };

            passwordHash = passwordHasher.HashPassword(normalUser, "123456");

            normalUser.PasswordHash = passwordHash;

            builder.HasData(normalUser);
        }
    }
}
