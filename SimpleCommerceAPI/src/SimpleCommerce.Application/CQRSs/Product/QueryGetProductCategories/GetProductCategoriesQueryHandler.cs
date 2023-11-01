using AutoMapper;
using MediatR;
using SimpleCommerce.Application.DTOs.Product;
using SimpleCommerce.Domain.Entities.Product;
using SimpleCommerce.Domain.Repositories.Product;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProductCategories
{
    public class GetProductCategoriesQueryHandler : IRequestHandler<GetProductCategoriesQueryRequest, GetProductCategoriesQueryResponse>
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IMapper _mapper;

        public GetProductCategoriesQueryHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }

        public Task<GetProductCategoriesQueryResponse> Handle(GetProductCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<ProductCategoryEntity> productCategories = _productCategoryRepository.GetAll();

            IEnumerable<ProductCategoryDTO> dtos = _mapper.Map<IEnumerable<ProductCategoryDTO>>(productCategories);

            return Task.FromResult(new GetProductCategoriesQueryResponse(dtos, request.Pagination));
        }
    }
}
