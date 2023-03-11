using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MMKTBackend.API;
using MMKTBackend.API.DTOs;
using MMKTBackend.API.Utils;
using MMKTBackend.Application.IProductServices;
using MMKTBackend.Application.Services;
using MMKTBackend.Domain;
using MMKTBackend.Domain.Entities;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMKTBackend.Controllers
{
    [OpenApiTag("API Productos MMKT",
                Description = "Web API para insertar productos (post (//API//productos)) " +
                "y ver la cantidad de productos añadidos a la base de datos (get (//API//nuevoProducto)).")]
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IProductService _productService;

        public ProductController(IMapper mapper, IProductService productService)
        {
            this.mapper = mapper;
            this._productService = productService;
        }

        [OpenApiTag("API Productos MMKT",
            Description = "Web API ver la cantidad de productos añadidos a la base de datos (get (//API//nuevoProducto)).")]
        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = _productService.GetAll().GetAwaiter().GetResult();
            await HttpContext.InsertPaginationParamitersInHeader(queryable);
            var products = await queryable.OrderBy(X => X.Name).Pagination(paginationDTO).ToListAsync();

            return mapper.Map<List<ProductDTO>>(products);
        }

        [OpenApiTag("API Nuevo Producto",
            Description = "Web API para insertar productos (post (//API//productos)) ")]
        [HttpPost]
        public async Task<ActionResult> Post([FromForm] ProductDTO productoDTO)
        {
            var nuevoProducto = mapper.Map<Product>(productoDTO);
            _productService.Insert(nuevoProducto);
            

            return NoContent();
        }
    }
}
