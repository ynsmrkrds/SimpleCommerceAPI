using AutoMapper;
using MediatR;
using SimpleCommerce.Application.DTOs.Order;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Entities.Order;
using SimpleCommerce.Domain.Repositories.Order;

namespace SimpleCommerce.Application.CQRSs.Order.QueryGetOwnOrders
{
    public class GetOwnOrdersQueryHandler : IRequestHandler<GetOwnOrdersQueryRequest, GetOwnOrdersQueryResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly TokenUtility _tokenUtility;

        public GetOwnOrdersQueryHandler(IOrderRepository orderRepository, IMapper mapper, TokenUtility tokenUtility)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _tokenUtility = tokenUtility;
        }

        public Task<GetOwnOrdersQueryResponse> Handle(GetOwnOrdersQueryRequest request, CancellationToken cancellationToken)
        {
            int userID = _tokenUtility.DecodeTokenInRequest().UserID;

            IEnumerable<OrderEntity> orders = _orderRepository.GetAllByUserID(userID);

            IEnumerable<OrderDTO> dtos = _mapper.Map<IEnumerable<OrderDTO>>(orders);

            return Task.FromResult(new GetOwnOrdersQueryResponse(dtos, request.Pagination));
        }
    }
}
