using SimpleCommerce.Domain.Entities.User;
using SimpleCommerce.Domain.Repositories.User;
using TransportGlobal.Infrastructure.Context;

namespace SimpleCommerce.Infrastructure.Repositories.User
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        public UserRepository(SimpleCommerceDBContext context) : base(context)
        {
        }

        public bool IsExistsWithSameEmail(string email)
        {
            return GetAll()
                .Where(x => x.IsDeleted == false)
                .Any(x => x.Email == email);
        }

        public UserEntity? ValidateUser(string email, string passwordHash)
        {
            return GetAll()
                .Where(x => x.IsDeleted == false)
                .Where(x => x.Email == email && x.PasswordHash == passwordHash)
                .FirstOrDefault();
        }
    }
}
