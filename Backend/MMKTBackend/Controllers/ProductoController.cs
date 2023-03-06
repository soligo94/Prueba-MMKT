using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MMKTBackend.API;
using MMKTBackend.API.DTOs;
using MMKTBackend.API.Utils;
using MMKTBackend.Domain;
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
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductoController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [OpenApiTag("API Productos MMKT",
            Description = "Web API ver la cantidad de productos añadidos a la base de datos (get (//API//nuevoProducto)).")]
        [HttpGet("/api/productos")]
        public async Task<ActionResult<List<ProductoDTO>>> Get()
        {
            var queryable = context.Productos.AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnCabecera(queryable);
            var productos = await queryable.OrderBy(X => X.Nombre).ToListAsync();

            return mapper.Map<List<ProductoDTO>>(productos);
        }

        [OpenApiTag("API Nuevo Producto",
            Description = "Web API para insertar productos (post (//API//productos)) ")]
        [HttpPost("/api/nuevoProducto")]
        public async Task<ActionResult> Post([FromBody] ProductoDTO productoDTO)
        {
            var nuevoProducto = mapper.Map<Producto>(productoDTO);
            context.Add(nuevoProducto);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
