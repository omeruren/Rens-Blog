using AutoMapper;
using RensBlog.Application.Features.Socials.Commands;
using RensBlog.Application.Features.Socials.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Socials.Mappings;

public class SocialMappingProfile : Profile
{
    public SocialMappingProfile()
    {
        CreateMap<Social, CreateSocialCommand>().ReverseMap();
        CreateMap<Social, UpdateSocialCommand>().ReverseMap();
        CreateMap<Social, GetSocialsQueryResult>().ReverseMap();
        CreateMap<Social, GetSocialByIdQueryResult>().ReverseMap();
    }
}
