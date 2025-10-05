using FluentValidation;
using RensBlog.Application.Features.SubComments.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.SubComments.Validators
{
    public class CreateSubCommentValidator : AbstractValidator<CreateSubCommentCommand>
    {
        public CreateSubCommentValidator()
        {
            RuleFor(x => x.CommentId)
                .NotEmpty()
                .WithMessage("Comment Id can not be empty");
            RuleFor(x => x.Body)
                .NotEmpty()
                .WithMessage("Comment can not be empty")
                .MaximumLength(300)
                .WithMessage("Comment can be maximum 300 characters")
                .MinimumLength(3)
                .WithMessage("Comment must be at least 3 characters");
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
}
