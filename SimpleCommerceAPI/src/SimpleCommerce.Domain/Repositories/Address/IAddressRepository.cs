using SimpleCommerce.Domain.Entities.Address;

namespace SimpleCommerce.Domain.Repositories.Address
{
    public interface IAddressRepository : IRepository<AddressEntity>
    {
        bool IsExistsWithSameTitle(string title, int userID);

        IEnumerable<AddressEntity> GetAllByUserID(int userID);
    }
}
