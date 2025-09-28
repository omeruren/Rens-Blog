using FluentValidation;
using RensBlog.Application.Features.Users.Commands;

namespace RensBlog.Application.Features.Users.Validators;

public class CreateUserValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("First Name is can not be empty");
        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Last Name is can not be empty");
        RuleFor(x => x.UserName)
            .NotEmpty()
            .WithMessage("Username is can not be empty");
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email address is can not be empty")
            .EmailAddress()
            .WithMessage("Email is not valid");
        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is can not be empty");
    }
}
