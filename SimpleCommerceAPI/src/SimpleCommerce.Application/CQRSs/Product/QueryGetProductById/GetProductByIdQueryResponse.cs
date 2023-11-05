using SimpleCommerce.Application.DTOs.Product;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProductById
{
    public class GetProductByIdQueryResponse : BaseQueryItemResponse<ProductDTO>
    {
        public GetProductByIdQueryResponse(ProductDTO item) : base(item)
        {
        }
    }
}
