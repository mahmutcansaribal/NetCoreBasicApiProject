﻿using ApiProjectCamp.WebApi.Dtos.FeatureDtos;
using ApiProjectCamp.WebApi.Dtos.MessageDtos;
using ApiProjectCamp.WebApi.Dtos.ProductDtos;
using ApiProjectCamp.WebApi.Entities;
using AutoMapper;

namespace ApiProjectCamp.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature,CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature,GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message,CreateMessageDto>().ReverseMap();
            CreateMap<Message,UpdateMessageDto>().ReverseMap();
            CreateMap<Message,ResultMessageDto>().ReverseMap();
            CreateMap<Message,GetByIdMessageDto>().ReverseMap();

            CreateMap<Product,CreateProductDto>().ReverseMap();

            //Todo : Ürünleri Kategori İsmiyle getirebilmek için Mapper düzenlemesi.
            CreateMap<Product,ResultProductWithCategoryDto>().ForMember(x=>x.CategoryName, y=> y.MapFrom(z=>z.Category.CategoryName)).ReverseMap();
            /*
             * forMember
             * 1. x=> Kategori Adını getirmek istiyorum?
             * 2. y=> Kategori Adını neden getireceğim?
             * 3. z=> Kategori Adı nerede bulunuyor?
             */
        }
    }
}
