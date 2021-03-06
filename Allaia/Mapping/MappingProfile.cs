﻿using Allaia.Models;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allaia.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<ShopColllection, ShopCollectionViewModel>();
            CreateMap<Label, LabelViewModel>();
            CreateMap<Discount, DisCountViewModel>();
            CreateMap<Product, ProductViewModel>()

            .ForMember(d => d.Photos, opt => opt.MapFrom(src => src.Photos.OrderBy(p => p.OrderBy).Select(p => p.Image)))
               .ForMember(d => d.Discount, opt => opt.MapFrom(src => src.Discounts
                                                                         .Where(d => d.Discount.StartDate <= DateTime.Now && d.Discount.EndDate >= DateTime.Now)
                                                                         .OrderByDescending(d => d.Discount.AddedDate)
                                                                         .FirstOrDefault().Discount));
            CreateMap<Brand, BrandViewModel>();
            CreateMap<Basket, BasketViewModel>();
        }
    }
}
