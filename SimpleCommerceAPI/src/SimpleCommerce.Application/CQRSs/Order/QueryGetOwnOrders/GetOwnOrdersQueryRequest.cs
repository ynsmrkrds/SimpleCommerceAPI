using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Application.CQRSs.Order.QueryGetOwnOrders
{
    public class GetOwnOrdersQueryRequest : BaseQueryListRequest<GetOwnOrdersQueryResponse>
    {
        public GetOwnOrdersQueryRequest(PaginationModel pagination) : base(pagination)
        {
        }
    }
}
