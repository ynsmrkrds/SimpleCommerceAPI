using Microsoft.EntityFrameworkCore;
using SimpleCommerce.Domain.Entities.Product;
using SimpleCommerce.Domain.Repositories.Product;
using TransportGlobal.Infrastructure.Context;

namespace SimpleCommerce.Infrastructure.Repositories.Product
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {
        public ProductRepository(SimpleCommerceDBContext context) : base(context)
        {
        }

        public override IQueryable<ProductEntity> GetAll()
        {
            return base.GetAll()
                .Include(x => x.Category);
        }
    }
}
