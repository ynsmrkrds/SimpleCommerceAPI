using AutoMapper;
using MediatR;
using SimpleCommerce.Application.DTOs.Order;
using SimpleCommerce.Application.Utilities.Token;
using SimpleCommerce.Domain.Constants;
using SimpleCommerce.Domain.Entities.Order;
using SimpleCommerce.Domain.Repositories.Order;

namespace SimpleCommerce.Application.CQRSs.Order.CommandCreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly TokenUtility _tokenUtility;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IOrderItemRepository orderItemRepository, TokenUtility tokenUtility, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _tokenUtility = tokenUtility;
            _mapper = mapper;
        }

        public Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            string userID = _tokenUtility.DecodeTokenInRequest().UserID;

            OrderEntity orderEntity = new(userID, request.AddressID);
            orderEntity = _orderRepository.Add(orderEntity);

            int effectedRows = _orderRepository.SaveChanges();
            if (effectedRows == 0) return Task.FromResult(new CreateOrderCommandResponse(ResponseConstants.CreateFailed));

            List<OrderItemEntity> orderItems = _mapper.Map<List<OrderItemDTOForCreate>, List<OrderItemEntity>>(request.Items);
            foreach (OrderItemEntity orderItem in orderItems)
            {
                orderItem.OrderID = orderEntity.ID;
                _orderItemRepository.Add(orderItem);
            }

            effectedRows = _orderItemRepository.SaveChanges();
            if (effectedRows == 0) return Task.FromResult(new CreateOrderCommandResponse(ResponseConstants.CreateFailed));

            return Task.FromResult(new CreateOrderCommandResponse(ResponseConstants.SuccessfullyCreated));
        }
    }
}
