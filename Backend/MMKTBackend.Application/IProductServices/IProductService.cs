using MMKTBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMKTBackend.Application.IProductServices
{
    public interface IProductService
    {
        Task<IQueryable<Product>> GetAll();
        void Insert(Product productEntity);
    }
}
