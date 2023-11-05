using MediatR;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProductById
{
    public class GetProductByIdQueryRequest : IRequest<GetProductByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetProductByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}
