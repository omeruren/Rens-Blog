using FluentValidation;
using RensBlog.Application.Features.Messages.Commands;

namespace RensBlog.Application.Features.Messages.Validators;

public class UpdateMessageValidator : AbstractValidator<UpdateMessageCommand>
{
    public UpdateMessageValidator()
    {
        RuleFor(x => x.Id)
             .NotEmpty().WithMessage("Id is required");
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("A valid email is required.")
            .MaximumLength(100).WithMessage("Email must not exceed 100 characters.");
        RuleFor(x => x.Subject)
            .NotEmpty().WithMessage("Subject is required.")
            .MaximumLength(200).WithMessage("Subject must not exceed 200 characters.");
        RuleFor(x => x.MessageBody)
            .NotEmpty().WithMessage("Message body is required.")
            .Length(2, 2000).WithMessage("Message body must be between 2 and 2000 characters.");
    }
}
