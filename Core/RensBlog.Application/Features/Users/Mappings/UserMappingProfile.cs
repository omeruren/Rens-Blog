using AutoMapper;
using RensBlog.Application.Features.Users.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Users.Mappings;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<AppUser, CreateUserCommand>().ReverseMap();
    }
}
