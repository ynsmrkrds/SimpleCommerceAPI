using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProductCategories
{
    public class GetProductCategoriesQueryRequest : BaseQueryListRequest<GetProductCategoriesQueryResponse>
    {
        public GetProductCategoriesQueryRequest(PaginationModel pagination) : base(pagination)
        {
        }
    }
}
