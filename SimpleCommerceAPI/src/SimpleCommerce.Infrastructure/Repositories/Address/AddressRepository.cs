using SimpleCommerce.Domain.Entities.Address;
using SimpleCommerce.Domain.Repositories.Address;
using TransportGlobal.Infrastructure.Context;

namespace SimpleCommerce.Infrastructure.Repositories.Address
{
    public class AddressRepository : Repository<AddressEntity>, IAddressRepository
    {
        public AddressRepository(SimpleCommerceDBContext context) : base(context)
        {
        }

        public bool IsExistsWithSameTitle(string title, int userID)
        {
            return GetAll()
                .Where(x => x.UserID == userID)
                .Any(x => x.Title == title);
        }

        public IEnumerable<AddressEntity> GetAllByUserID(int userID)
        {
            return GetAll()
                .Where(x => x.UserID == userID);
        }
    }
}
