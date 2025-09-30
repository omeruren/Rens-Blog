using FluentValidation;
using RensBlog.Application.Features.Users.Queries;
using RensBlog.Application.Features.Users.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Users.Validators
{
    public class GetLoginValidator : AbstractValidator<GetLoginQuery>
    {
        public GetLoginValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");
            RuleFor(x=>x.ConfirmPassword)
                .Equal(x=>x.Password).WithMessage("Password and Confirm Password must match.");
        }
    }
}
