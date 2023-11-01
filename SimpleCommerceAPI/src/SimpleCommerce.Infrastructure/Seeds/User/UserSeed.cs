using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Entities.User;

namespace SimpleCommerce.Infrastructure.Seeds.User
{
    internal class UserSeed : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            string passwordHash = "wEXC+zsV9xjSjrlsyqK58SjE3IasyI327aF25jotP7/98elqf/+cd+KzKDv2PSPBaeSE0/8cPOnOJYtkZ3y1Eg=="; // 123456

            UserEntity shipperUser = new("John", "Doe", "john.doe@gmail.com", passwordHash)
            {
                ID = 1
            };
            builder.HasData(shipperUser);
        }
    }
}
