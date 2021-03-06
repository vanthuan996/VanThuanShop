﻿using AutoMapper;
using VanThuanShop.Model.Models;
using VanThuanShop.Web.Models;

namespace VanThuanShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>().MaxDepth(2);
                cfg.CreateMap<PostCategory, PostCategoryViewModel>().MaxDepth(2);
                cfg.CreateMap<Tag, TagViewModel>().MaxDepth(2);
            });
        }
    }
}