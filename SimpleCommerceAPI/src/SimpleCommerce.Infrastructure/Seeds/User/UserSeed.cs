using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Entities.User;

namespace SimpleCommerce.Infrastructure.Seeds.User
{
    internal class UserSeed : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            string passwordHash = "f88kKg9BTfLRX79/OCyi3SkMT+9tp6HUkpNDKb0B1i3wicsu7ibl3Gx1WTiGqQMI9f5IkY4nABU+L/XVNWKg5A=="; // 123456

            UserEntity user = new("John", "Doe", "john.doe@gmail.com", passwordHash)
            {
                ID = 1
            };

            builder.HasData(user);
        }
    }
}
