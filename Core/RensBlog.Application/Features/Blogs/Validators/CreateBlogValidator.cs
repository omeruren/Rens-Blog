using FluentValidation;
using RensBlog.Application.Features.Blogs.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Blogs.Validators
{
    public class CreateBlogValidator : AbstractValidator<CreateBlogCommand>
    {
        public CreateBlogValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is can not be empty")
                .MinimumLength(5)
                .WithMessage("Title is must be at least 5 characters")
                .MaximumLength(60)
                .WithMessage("Title can be maximum 60 characters");
                

            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is can not be empty");
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description is can not be empty");
            RuleFor(x => x.CoverImage)
                .NotEmpty()
                .WithMessage("Cover Image is can not be empty");
            RuleFor(x => x.BlogImage)
                .NotEmpty()
                .WithMessage("Blog Image is can not be empty");
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("User is can not be empty");
        }
    }
}
