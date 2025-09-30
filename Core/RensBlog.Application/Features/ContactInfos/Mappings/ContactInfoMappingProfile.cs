using AutoMapper;
using RensBlog.Application.Features.ContactInfos.Result;
using RensBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.ContactInfos.Mappings;

public class ContactInfoMappingProfile : Profile
{
    public ContactInfoMappingProfile()
    {
        CreateMap<ContactInfo, GetContactInfosQueryResult>().ReverseMap();
    }
}
