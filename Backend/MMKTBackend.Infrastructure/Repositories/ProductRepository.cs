using MMKTBackend.Domain;
using MMKTBackend.Domain.Entities;
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

        public void AddProduct(Product product)
        {
            _ProductContext.Products.Add(product);
            _ProductContext.SaveChanges();
        }

        public async Task<IQueryable<Domain.Entities.Product>> GetListOfproducts()
        {
            return _ProductContext.Products.AsQueryable();
        }
    }
}
