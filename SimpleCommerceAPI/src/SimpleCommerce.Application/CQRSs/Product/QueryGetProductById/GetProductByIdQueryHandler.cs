using AutoMapper;
using MediatR;
using SimpleCommerce.Application.DTOs.Product;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.Product;
using SimpleCommerce.Domain.Exceptions;
using SimpleCommerce.Domain.Repositories.Product;

namespace SimpleCommerce.Application.CQRSs.Product.QueryGetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, GetProductByIdQueryResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<GetProductByIdQueryResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            ProductEntity? productEntity = _productRepository.GetByID(request.ID) ?? throw new ClientSideException(ExceptionConstants.NotFoundProduct);

            ProductDTO productDTO = _mapper.Map<ProductEntity, ProductDTO>(productEntity);

            return Task.FromResult(new GetProductByIdQueryResponse(productDTO));
        }
    }
}
