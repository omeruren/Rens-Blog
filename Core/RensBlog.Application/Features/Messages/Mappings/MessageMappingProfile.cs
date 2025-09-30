using AutoMapper;
using RensBlog.Application.Features.Messages.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Messages.Mappings;

public class MessageMappingProfile : Profile
{
    public MessageMappingProfile()
    {
        CreateMap<Message, CreateMessageCommand>().ReverseMap();
    }
}
