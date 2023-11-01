using SimpleCommerce.Application.DTOs.Product;
using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProductCategories
{
    public class GetProductCategoriesQueryResponse : BaseQueryListResponse<ProductCategoryDTO>
    {
        public GetProductCategoriesQueryResponse(IEnumerable<ProductCategoryDTO> list, PaginationModel paginationModel) : base(list, paginationModel)
        {
        }
    }
}
