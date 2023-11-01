using AutoMapper;
using MediatR;
using SimpleCommerce.Application.DTOs.Product;
using SimpleCommerce.Domain.Entities.Product;
using SimpleCommerce.Domain.Repositories.Product;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProducts
{
    public class GetProductCategoriesQueryHandler : IRequestHandler<GetProductsQueryRequest, GetProductsQueryResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductCategoriesQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<GetProductsQueryResponse> Handle(GetProductsQueryRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<ProductEntity> productCategories = _productRepository.GetAll();

            IEnumerable<ProductDTO> dtos = _mapper.Map<IEnumerable<ProductDTO>>(productCategories);

            return Task.FromResult(new GetProductsQueryResponse(dtos, request.Pagination));
        }
    }
}
