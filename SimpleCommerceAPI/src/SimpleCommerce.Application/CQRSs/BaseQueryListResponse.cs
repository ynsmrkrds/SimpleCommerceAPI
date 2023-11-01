using SimpleCommerce.Domain.Extensions;
using SimpleCommerce.Domain.Models;

namespace TransportGlobal.Application.DTOs.CQRSDTOs
{
    public abstract class BaseQueryListResponse<T>
    {
        public ICollection<T> List { get; set; }

        public int TotalCount { get; set; }

        protected BaseQueryListResponse(IEnumerable<T> list, PaginationModel paginationModel)
        {
            List = list.WithPagination(paginationModel).ToList();
            TotalCount = list.Count();
        }
    }
}
