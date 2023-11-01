using SimpleCommerce.Application.DTOs.Order;
using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.Order.QueryGetOwnOrders
{
    public class GetOwnOrdersQueryResponse : BaseQueryListResponse<OrderDTO>
    {
        public GetOwnOrdersQueryResponse(IEnumerable<OrderDTO> list, PaginationModel paginationModel) : base(list, paginationModel)
        {
        }
    }
}
