using AutoMapper;
using RensBlog.Application.Features.Socials.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Socials.Mappings;

public class SocialMappingProfile : Profile
{
    public SocialMappingProfile()
    {
        CreateMap<Social, CreateSocialCommand>().ReverseMap();
    }
}
