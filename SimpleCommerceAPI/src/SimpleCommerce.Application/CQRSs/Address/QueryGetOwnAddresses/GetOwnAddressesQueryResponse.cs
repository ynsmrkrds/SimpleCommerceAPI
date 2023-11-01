using SimpleCommerce.Application.DTOs.Address;
using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.Address.QueryGetOwnAddresses
{
    public class GetOwnAddressesQueryResponse : BaseQueryListResponse<AddressDTO>
    {
        public GetOwnAddressesQueryResponse(IEnumerable<AddressDTO> list, PaginationModel paginationModel) : base(list, paginationModel)
        {
        }
    }
}
