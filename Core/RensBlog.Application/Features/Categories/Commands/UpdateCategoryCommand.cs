using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Categories.Commands;

public record UpdateCategoryCommand(Guid Id, string CategoryName) : IRequest<BaseResult<bool>>;

