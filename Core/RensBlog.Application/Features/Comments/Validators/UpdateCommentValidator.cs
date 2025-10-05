using FluentValidation;
using RensBlog.Application.Features.Comments.Commands;

namespace RensBlog.Application.Features.Comments.Validators;

public class UpdateCommentValidator : AbstractValidator<UpdateCommentCommand>
{
    public UpdateCommentValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id is can not be empty");
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("User is can not be empty");
        RuleFor(x => x.BlogId)
            .NotEmpty()
            .WithMessage("Blog is can not be empty");
        RuleFor(x => x.Body)
            .NotEmpty()
            .WithMessage("Message body is can not be empty");
        RuleFor(x => x.FirstName)
           .NotEmpty()
           .WithMessage("First Name is can not be empty");
        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Last Name is can not be empty");
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email is can not be empty");
    }


}
