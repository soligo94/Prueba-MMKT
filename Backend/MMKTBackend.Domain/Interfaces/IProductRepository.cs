using MMKTBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMKTBackend.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IQueryable<Domain.Entities.Product>> GetListOfproducts();
        void AddProduct(Domain.Entities.Product product);
    }
}
