using SimpleCommerce.Application.DTOs.Product;
using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProducts
{
    public class GetProductsQueryResponse : BaseQueryListResponse<ProductDTO>
    {
        public GetProductsQueryResponse(IEnumerable<ProductDTO> list, PaginationModel paginationModel) : base(list, paginationModel)
        {
        }
    }
}
