using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Domain.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> WithPagination<T>(this IEnumerable<T> source, PaginationModel paginationModel)
        {
            return source
                .Skip(paginationModel.Page * paginationModel.Size)
                .Take(paginationModel.Size);
        }
    }
}
