using AutoMapper;
using MMKTBackend.API.DTOs;
using MMKTBackend.Domain;
using MMKTBackend.Domain.Entities;

namespace MMKTBackend.API.Utils
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<ProductDTO, Product>();
        }
    }
}
