using SimpleCommerce.Domain.Entities.Product;
using SimpleCommerce.Domain.Repositories.Product;
using TransportGlobal.Infrastructure.Context;

namespace SimpleCommerce.Infrastructure.Repositories.Product
{
    internal class ProductCategoryRepository : Repository<ProductCategoryEntity>, IProductCategoryRepository
    {
        public ProductCategoryRepository(SimpleCommerceDBContext context) : base(context)
        {
        }
    }
}
