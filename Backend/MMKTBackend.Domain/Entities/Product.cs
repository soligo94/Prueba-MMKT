using MMKTBackend.Domain.Enums;
using System;

namespace MMKTBackend.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public FamilyProductEnum Family { get; set; }
    }
}
