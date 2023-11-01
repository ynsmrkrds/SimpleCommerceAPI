using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Application.CQRSs.Address.QueryGetOwnAddresses
{
    public class GetOwnAddressesQueryRequest : BaseQueryListRequest<GetOwnAddressesQueryResponse>
    {
        public GetOwnAddressesQueryRequest(PaginationModel pagination) : base(pagination)
        {
        }
    }
}
