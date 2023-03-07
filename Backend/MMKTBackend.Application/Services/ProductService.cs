using MMKTBackend.Application.IProductServices;
using MMKTBackend.Domain.Entities;
using MMKTBackend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMKTBackend.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IQueryable<Product>> GetAll()
        {
            return await _productRepository.GetListOfproducts();
        }

        public void Insert(Product productEntity)
        {
            _productRepository.AddProduct(productEntity);
        }
    }
}
