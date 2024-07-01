﻿using AutoMapper;
using ShoppingBasketAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketAPI.DTOs.AutoMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.IsFeatured, opt => opt.MapFrom(src => src.FeaturedProduct != null))
                .ForMember(dest => dest.DiscountRate, opt => opt.MapFrom(src => src.Discount != null ? src.Discount.DiscountRate : 0.0))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images));

            CreateMap<Image, ImageResponseDTO>();
        }
    }
}