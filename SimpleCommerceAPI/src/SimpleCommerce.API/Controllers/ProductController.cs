using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleCommerce.Application.CQRSs.Product.QueryGetProductById;
using SimpleCommerce.Application.CQRSs.Product.QueryGetProducts;
using SimpleCommerce.Domain.Models;
using TransportGlobal.API.Controllers;

namespace SimpleCommerce.API.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{page}/{size}")]
        public async Task<IActionResult> GetAll(int page, int size)
        {
            GetProductsQueryResponse queryResponse = await _mediator.Send(new GetProductsQueryRequest(new PaginationModel(page, size)));
            return CreateActionResult(queryResponse);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            GetProductByIdQueryResponse queryResponse = await _mediator.Send(new GetProductByIdQueryRequest(id));
            return CreateActionResult(queryResponse.Item);
        }
    }
}
