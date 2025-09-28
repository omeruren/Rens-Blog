using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Categories.Commands;

public record RemoveCategoryCommand(Guid Id) : IRequest<BaseResult<bool>>;

