using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleCommerce.Application.CQRSs.Address.CommandCreateAddress;
using SimpleCommerce.Application.CQRSs.Address.QueryGetOwnAddresses;
using SimpleCommerce.Domain.Models;
using TransportGlobal.API.Controllers;

namespace SimpleCommerce.API.Controllers
{
    public class AddressController : BaseController
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{page}/{size}")]
        public async Task<IActionResult> GetAll(int page, int size)
        {
            GetOwnAddressesQueryResponse queryResponse = await _mediator.Send(new GetOwnAddressesQueryRequest(new PaginationModel(page, size)));
            return CreateActionResult(queryResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAddressCommandRequest request)
        {
            CreateAddressCommandResponse commandResponse = await _mediator.Send(request);
            return CreateActionResult(commandResponse.Response);
        }
    }
}
