using AutoMapper;
using RensBlog.Application.Features.Categories.Results;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Mappings;

internal class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
    }
}
