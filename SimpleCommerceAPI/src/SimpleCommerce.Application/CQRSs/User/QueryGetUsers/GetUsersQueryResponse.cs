using SimpleCommerce.Application.DTOs.User;
using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.User.QueryGetUsers
{
    public class GetUsersQueryResponse : BaseQueryListResponse<UserDTO>
    {
        public GetUsersQueryResponse(IEnumerable<UserDTO> list, PaginationModel paginationModel) : base(list, paginationModel)
        {
        }
    }
}
