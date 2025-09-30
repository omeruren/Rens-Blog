using AutoMapper;
using RensBlog.Application.Features.ContactInfos.Commands;
using RensBlog.Application.Features.ContactInfos.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.ContactInfos.Mappings;

public class ContactInfoMappingProfile : Profile
{
    public ContactInfoMappingProfile()
    {
        CreateMap<ContactInfo, GetContactInfosQueryResult>().ReverseMap();
        CreateMap<ContactInfo, GetContactInfoByIdQueryResult>().ReverseMap();
        CreateMap<ContactInfo, CreateContactInfoCommand>().ReverseMap();

    }
}
