using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleCommerce.Application.CQRSs.Order.CommandCreateOrder;
using SimpleCommerce.Application.CQRSs.Order.QueryGetOwnOrders;
using SimpleCommerce.Application.CQRSs.Product.QueryGetProductCategories;
using SimpleCommerce.Domain.Models;
using TransportGlobal.API.Controllers;

namespace SimpleCommerce.API.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{page}/{size}")]
        public async Task<IActionResult> GetAll(int page, int size)
        {
            GetOwnOrdersQueryResponse queryResponse = await _mediator.Send(new GetOwnOrdersQueryRequest(new PaginationModel(page, size)));
            return CreateActionResult(queryResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrderCommandRequest request)
        {
            CreateOrderCommandResponse commandResponse = await _mediator.Send(request);
            return CreateActionResult(commandResponse.Response);
        }
    }
}
