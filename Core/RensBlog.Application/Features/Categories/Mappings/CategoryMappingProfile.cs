using AutoMapper;
using RensBlog.Application.Features.Categories.Commands;
using RensBlog.Application.Features.Categories.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Mappings;

internal class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
        CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
        CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
    }
}
