using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProducts
{
    public class GetProductsQueryRequest : BaseQueryListRequest<GetProductsQueryResponse>
    {
        public GetProductsQueryRequest(PaginationModel pagination) : base(pagination)
        {
        }
    }
}
