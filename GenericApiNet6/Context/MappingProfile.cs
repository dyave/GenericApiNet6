using AutoMapper;

namespace GenericApiNet6.Context
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Product, Dtos.ProductDto>();
        }
    }
}
