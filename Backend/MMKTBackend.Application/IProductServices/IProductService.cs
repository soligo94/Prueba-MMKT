using MMKTBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMKTBackend.Application.IProductServices
{
    public interface IProductService<T>
    {
        Task<IReadOnlyList<T>> GetAll();
        void Insert(T entity);
    }
}
