﻿using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.SubComments.Commands;

public record UpdateSubCommentCommand : IRequest<BaseResult<object>>
{
    public Guid Id { get; set; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Body { get; init; }
    public Guid CommentId { get; init; }
}
