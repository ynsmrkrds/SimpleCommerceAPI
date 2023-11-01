using MediatR;
using SimpleCommerce.Domain.Models;
using TransportGlobal.Application.DTOs.CQRSDTOs;

namespace SimpleCommerce.Application.CQRSs
{
    public abstract class BaseQueryListRequest<T> : IRequest<T>
    {
        public PaginationModel Pagination { get; set; }

        protected BaseQueryListRequest(PaginationModel pagination)
        {
            Pagination = pagination;
        }
    }
}
