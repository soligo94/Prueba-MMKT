using MMKTBackend.Domain.Enums;
using System;

namespace MMKTBackend.API.DTOs
{
    public class ProductoDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public FamiliaProductoEnum Familia { get; set; }
    }
}
