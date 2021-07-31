using AutoMapper;
using PoC.Mapeador.AutoMapper.Models;

namespace PoC.Mapeador.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductRequest, ProductResponse>()
                .ForMember(destiny => destiny.Key, source => source.MapFrom(origin => origin.Crypt));
        }
    }
}
