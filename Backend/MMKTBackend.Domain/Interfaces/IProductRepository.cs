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
        Task<IReadOnlyList<Domain.Entities.Product>> GetListOfproducts();
    }
}
