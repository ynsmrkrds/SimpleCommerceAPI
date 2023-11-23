using SimpleCommerce.Domain.Entities.Address;

namespace SimpleCommerce.Domain.Repositories.Address
{
    public interface IAddressRepository : IRepository<AddressEntity>
    {
        bool IsExistsWithSameTitle(string title, string userID);

        IEnumerable<AddressEntity> GetAllByUserID(string userID);
    }
}
