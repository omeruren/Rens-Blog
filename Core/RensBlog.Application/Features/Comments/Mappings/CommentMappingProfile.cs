using AutoMapper;
using RensBlog.Application.Features.Comments.Commands;
using RensBlog.Application.Features.Comments.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Comments.Mappings;

public class CommentMappingProfile: Profile
{
    public CommentMappingProfile()
    {
        CreateMap<Comment, GetCommentsQueryResult>().ReverseMap();
        CreateMap<Comment, GetCommentByIdQueryResult>().ReverseMap();
        CreateMap<Comment, CreateCommentCommand>().ReverseMap();
    }
}
