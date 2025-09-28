using AutoMapper;
using RensBlog.Application.Features.Blogs.Results;
using RensBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Blogs.Mappings
{
    public class BlogMappingProfile : Profile
    {
        public BlogMappingProfile()
        {
            CreateMap<Blog, GetBlogsQueryResult>().ReverseMap();
        }
    }
}
