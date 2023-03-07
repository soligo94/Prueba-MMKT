using MMKTBackend.Domain.Enums;
using System;

namespace MMKTBackend.API.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public FamilyProductEnum Family { get; set; }
    }
}
