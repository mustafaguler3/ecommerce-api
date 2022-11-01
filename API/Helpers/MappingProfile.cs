using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(i => i.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(i => i.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(i => i.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}
