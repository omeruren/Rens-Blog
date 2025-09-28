using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Categories.Commands;

public record CreateCategoryCommand(string CategoryName) : IRequest<BaseResult<object>>; // immutable 


