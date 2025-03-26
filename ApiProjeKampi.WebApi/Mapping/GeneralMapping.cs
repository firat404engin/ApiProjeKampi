using ApiProjeKampi.WebApi.Dtos.FeatureDtos;
using ApiProjeKampi.WebApi.Dtos.MessageDtos;
using ApiProjeKampi.WebApi.Dtos.ProductDtos;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;
using System.Runtime.CompilerServices;

namespace ApiProjeKampi.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        { 
            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature,CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature,GetByIdFeatureDto>().ReverseMap();


            CreateMap<Message,ResultMessageDto>().ReverseMap();
            CreateMap<Message,GetByIdMessageDto>().ReverseMap();
            CreateMap<Message,UpdateMessageDto>().ReverseMap();
            CreateMap<Message,CreateMessageDto>().ReverseMap();

            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductWithCategoryDto>().ForMember(x=>x.CategoryName,y=>y.MapFrom(
                z => z.Category.CategoryName)).ReverseMap();


        }
    }
}
