using SimpleCommerce.Domain.Entities.User;

namespace SimpleCommerce.Domain.Repositories.User
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        bool IsExistsWithSameEmail(string email);

        UserEntity? ValidateUser(string email, string passwordHash);
    }
}
