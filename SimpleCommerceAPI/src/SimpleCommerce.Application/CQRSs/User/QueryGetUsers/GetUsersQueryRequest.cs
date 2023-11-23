using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Application.CQRSs.User.QueryGetUsers
{
    public class GetUsersQueryRequest : BaseQueryListRequest<GetUsersQueryResponse>
    {
        public GetUsersQueryRequest(PaginationModel pagination) : base(pagination)
        {
        }
    }
}
