using AutoMapper;
using RensBlog.Application.Features.Messages.Commands;
using RensBlog.Application.Features.Messages.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Messages.Mappings;

public class MessageMappingProfile : Profile
{
    public MessageMappingProfile()
    {
        CreateMap<Message, CreateMessageCommand>().ReverseMap();
        CreateMap<Message, GetMessagesQueryresult>().ReverseMap();
    }
}
