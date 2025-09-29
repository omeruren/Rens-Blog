using FluentValidation;
using RensBlog.Application.Features.Blogs.Commands;
using RensBlog.Application.Features.Comments.Commands;

namespace RensBlog.Application.Features.Comments.Validators;

public class CreateCommentValidator : AbstractValidator<CreateCommentCommand>
{
    public CreateCommentValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage("User is can not be empty");
        RuleFor(x => x.BlogId)
            .NotEmpty()
            .WithMessage("Blog is can not be empty");
        RuleFor(x => x.Body)
            .NotEmpty()
            .WithMessage("Message body is can not be empty");

    }
}
