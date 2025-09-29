using AutoMapper;
using RensBlog.Application.Features.SubComments.Commands;
using RensBlog.Application.Features.SubComments.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.SubComments.Mapping;

public class SubCommentMappingProfile : Profile
{
    public SubCommentMappingProfile()
    {
        CreateMap<SubComment, CreateSubCommentCommand>().ReverseMap();
        CreateMap<SubComment, GetSubCommentsQueryResult>().ReverseMap();
    }
}
