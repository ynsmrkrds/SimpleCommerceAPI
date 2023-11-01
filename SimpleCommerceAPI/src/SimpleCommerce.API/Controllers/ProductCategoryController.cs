using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleCommerce.Application.CQRSs.Product.QueryGetProductCategories;
using SimpleCommerce.Domain.Models;
using TransportGlobal.API.Controllers;

namespace SimpleCommerce.API.Controllers
{
    public class ProductCategoryController : BaseController
    {
        private readonly IMediator _mediator;

        public ProductCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{page}/{size}")]
        public async Task<IActionResult> GetAll(int page, int size)
        {
            GetProductCategoriesQueryResponse queryResponse = await _mediator.Send(new GetProductCategoriesQueryRequest(new PaginationModel(page, size)));
            return CreateActionResult(queryResponse);
        }
    }
}
