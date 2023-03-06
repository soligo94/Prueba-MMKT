using MMKTBackend.Domain;
using MMKTBackend.Domain.Interfaces;
using MMKTBackend.Infrastructure.ProductContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMKTBackend.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository 
    { 
        public ProductDbContext _ProductContext;
        public ProductRepository(ProductDbContext productContext)
        {
            _ProductContext = productContext;
        }

        public async Task<IReadOnlyList<Domain.Entities.Product>> GetListOfproducts()
        {
            return _ProductContext.Products.ToList();
        }
    }
}
