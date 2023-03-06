using AutoMapper;
using MMKTBackend.API.DTOs;
using MMKTBackend.Domain;

namespace MMKTBackend.API.Utils
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Producto, ProductoDTO>().ReverseMap();
            CreateMap<ProductoDTO, Producto>();
        }
    }
}
