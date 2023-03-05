using MMKTBackend.Domain.Enums;
using System;

namespace MMKTBackend.Domain
{
    public class Producto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public FamiliaProductoEnum Familia { get; set; }

    }
}
