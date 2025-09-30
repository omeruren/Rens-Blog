using FluentValidation;
using RensBlog.Application.Features.Socials.Commands;

namespace RensBlog.Application.Features.Socials.Validators;

public class CreateSocialValidator : AbstractValidator<CreateSocialCommand>
{
    public CreateSocialValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(100).WithMessage("Title must not exceed 100 characters.");
        RuleFor(x => x.Url).NotEmpty().WithMessage("Url is required.")
            .Must(x=>Uri.TryCreate(x,UriKind.Absolute, out _)).WithMessage("Uri must be a valid URL");
        RuleFor(RuleFor => RuleFor.Icon)
            .NotEmpty().WithMessage("Icon is required.")
            .MaximumLength(50).WithMessage("Icon must be exceed 50 characters");

    }
}
