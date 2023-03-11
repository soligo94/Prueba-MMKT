using MMKTBackend.API.DTOs;
using System.Linq;

namespace MMKTBackend.API.Utils
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Pagination<T>(this IQueryable<T> queryable, PaginationDTO paginacionDTO)
        {
            return queryable.Skip((paginacionDTO.Page - 1) * paginacionDTO.RecordsPerPage)
                .Take(paginacionDTO.RecordsPerPage);
        }
    }
}
