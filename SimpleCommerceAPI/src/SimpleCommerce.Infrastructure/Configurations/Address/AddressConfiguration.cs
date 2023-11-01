using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCommerce.Domain.Entities.Address;

namespace SimpleCommerce.Infrastructure.Configurations.Address
{
    internal class AddressConfiguration : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.HasOne(x => x.User)
               .WithMany(x => x.Addresses)
               .HasForeignKey(x => x.UserID)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Orders)
               .WithOne(x => x.Address)
               .HasForeignKey(x => x.AddressID)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
