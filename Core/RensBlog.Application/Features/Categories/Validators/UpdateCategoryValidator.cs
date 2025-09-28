using FluentValidation;
using RensBlog.Application.Features.Categories.Commands;

namespace RensBlog.Application.Features.Categories.Validators;

public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryCommand>
{
    public UpdateCategoryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Category Id con not be empty");

        RuleFor(x => x.CategoryName)
            .NotEmpty()
            .WithMessage("Category Name can not be empty")
            .MinimumLength(3)
            .WithMessage("Category Name must be at least 3 characters");
    }
}
