using FluentValidation;
using RensBlog.Application.Features.ContactInfos.Commands;

namespace RensBlog.Application.Features.ContactInfos.Validators;

public class CreateContactInfoValidator : AbstractValidator<CreateContactInfoCommand>
{
    public CreateContactInfoValidator()
    {
        RuleFor(x => x.Address)
            .NotEmpty().WithMessage("Address is required.")
            .MaximumLength(200).WithMessage("Address must not exceed 200 characters.");
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.")
            .MaximumLength(100).WithMessage("Email must not exceed 100 characters.");
        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Phone number is required.")
            .Matches(@"^\+?\d{1,14}$").WithMessage("Invalid phone number format.");
        RuleFor(x => x.MapUrl)

            .NotEmpty().WithMessage("Map URL is required.")
            .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute)).WithMessage("Invalid MAp Url format");
    }
}
