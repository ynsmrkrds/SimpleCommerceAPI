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
    }
}
